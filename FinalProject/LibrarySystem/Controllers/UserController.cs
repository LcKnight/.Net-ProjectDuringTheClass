
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using LibrarySystem.Models;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;

namespace LibrarySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly LibraryContext _context;

        public UserController(LibraryContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 用户注册，若成功返回用户信息携带token，若用户名重复，返回409
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        [HttpPost("/register")]
        public IActionResult Register(string useraccount, string password)
        {
            if (UserExists(useraccount))
            {
                return Conflict();
            }
            else
            {
                //先存，拿到自增的id
                User user = new User();
                user.UserAccount = useraccount;
                user.Pwd = password;
                _context.Users.Add(user);
                _context.SaveChanges();
                var user_new = _context.Users.Single(u => u.UserAccount == useraccount);
                //将id写到JWT中，二次存储
                var payload = new Dictionary<string, object>
               {
                    {"iss", "RecordProAPI" },
                    {"iat", DateTime.Now.ToString() },
                    {"name", useraccount },
                    {"id", user_new.UserId}
               };
                const string secret = "ezio0124";
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
                IJsonSerializer serializer = new JsonNetSerializer();
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
                var token = encoder.Encode(payload, secret);
                //刷新token
                user_new.Token = token;
                _context.Update<User>(user_new);
                _context.SaveChanges();
                return CreatedAtAction("Register", new { id = user.UserId }, user);
            }
        }

        /// <summary>
        /// 用户登录，成功返回用户信息，用户不存在返回404。密码错误返回417
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost("/login")]
        public ActionResult<User> Login(string useraccount, string password)
        {
            if (!UserExists(useraccount))
            {
                return NotFound();
            }
            else
            {
                var user = _context.Users.Single(u => u.UserAccount == useraccount);
                if (user.Pwd.Equals(password))
                {
                    return user;
                }
                else
                {
                    return StatusCode(417);
                }
            }
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }

        private bool UserExists(string useraccount)
        {
            return _context.Users.Any(e => e.UserAccount == useraccount);
        }
    }
}

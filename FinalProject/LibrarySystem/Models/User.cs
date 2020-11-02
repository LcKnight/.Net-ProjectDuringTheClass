using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    /// <summary>
    /// 普通用户
    /// </summary>
    public class User
    {

        /// <summary>
        /// ID主键
        /// </summary>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string UserAccount { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        /// 
        [Column(TypeName = "varchar(200)")]
        public string Pwd { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string UserName { get; set; }



        /// <summary>
        /// 登陆凭证
        /// </summary>
        /// 
        [Column(TypeName = "varchar(200)")]
        public string Token { get; set; }
    }
}

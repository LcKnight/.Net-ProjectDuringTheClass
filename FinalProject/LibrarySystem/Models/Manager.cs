using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class Manager
    {
        /// <summary>
        /// Id主键
        /// </summary>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManagerId { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string ManagerAccount { get; set; }


        /// <summary>
        /// 密码
        /// </summary>


        [Column(TypeName = "varchar(200)")]
        public string Pwd { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>

        [Column(TypeName = "varchar(200)")]
        public string ManagerName { get; set; }

        /// <summary>
        /// 登陆凭证
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string Token { get; set; }

    }
}

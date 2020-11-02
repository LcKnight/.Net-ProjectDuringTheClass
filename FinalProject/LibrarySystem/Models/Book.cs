using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    /// <summary>
    /// 书籍
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 书籍主键
        /// </summary>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BookId {get;set;}

        /// <summary>
        /// 书籍姓名
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string BookName { get; set; }

        /// <summary>
        /// 书籍ISBN
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string ISBN { get; set; }


        /// <summary>
        /// 书籍作者
        /// </summary>
        [Column(TypeName = "varchar(200)")]

        public string Author { get; set; }


        /// <summary>
        /// 书籍类别
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string Category { get; set; }


        /// <summary>
        /// 书籍的PositionId
        /// </summary>
        public int PositionId { get; set; }

        /// <summary>
        /// 书籍对应位置的状态，如在书架，不在书架
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string PState { get; set; }

        /// <summary>
        /// 书籍的借出状态
        /// </summary>
        [Column(TypeName = "varchar(200)")]
        public string BType { get; set; }
    }
}

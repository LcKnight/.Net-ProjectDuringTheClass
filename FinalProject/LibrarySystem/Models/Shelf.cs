using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    /// <summary>
    /// 书架
    /// </summary>
    public class Shelf
    {
        /// <summary>
        /// 书架主键
        /// </summary>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ShelfId { get; set; }

        /// <summary>
        /// 书架容量
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// 书架的层数
        /// </summary>
        public int Layers { get; set; }

        /// <summary>
        /// 书架对应的图书馆Id
        /// </summary>
        public int LibraryId { get; set; }

        /// <summary>
        /// 书架摆放的书的类型
        /// </summary>
        [Column(TypeName ="varchar(200)")]
        public string Category { get; set; }

    }
}

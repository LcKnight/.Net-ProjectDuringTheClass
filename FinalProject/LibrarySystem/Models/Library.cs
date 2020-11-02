using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    /// <summary>
    /// 图书馆
    /// </summary>
    public class Library
    {

        /// <summary>
        /// 图书馆主键
        /// </summary>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibraryId { get; set; }

        /// <summary>
        /// 图书馆名称
        /// </summary>
        [Column(TypeName ="varchar(200)")]
        public string LibraryName { get; set; }







    }
}

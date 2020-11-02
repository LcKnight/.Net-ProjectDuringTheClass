using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    /// <summary>
    /// 存书位置
    /// </summary>
    public class Position
    {        /// <summary>
             /// 每个存书位置主键
             /// </summary>
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PositionId { get; set; }
        /// <summary>
        /// 书架Id
        /// </summary>
        public int ShelfId { get; set; }
        /// <summary>
        /// 层数
        /// </summary>
        public int LayerIndex { get; set; }
        /// <summary>
        /// 在某层的Index索引
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 该位置是否有书
        /// </summary>
        public bool Tag { get; set; }




    }
}

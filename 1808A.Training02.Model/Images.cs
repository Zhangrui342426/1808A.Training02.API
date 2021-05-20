using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.Model
{
    /// <summary>
    /// 房源图片
    /// </summary>
    public class Images
    {
        /// <summary>
        /// 图片id
        /// </summary>
        public int Mid { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string Mimg { get; set; }
        /// <summary>
        /// 房源外键
        /// </summary>
        public int New_HouseId { get; set; }
        /// <summary>
        /// 小区管理外键
        /// </summary>
        public int CommunityId { get; set; }
    }
}

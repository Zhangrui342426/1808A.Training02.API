using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.Model
{
    /// <summary>
    /// 地区表
    /// </summary>
    public class TBDistrict
    {
        /// <summary>
        /// 地区id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 绑定省id
        /// </summary>
        public int pid { get; set; }
        /// <summary>
        /// 省市名称
        /// </summary>
        public string district { get; set; }
        /// <summary>
        /// 区级id
        /// </summary>
        public int level { get; set; }
    }
}

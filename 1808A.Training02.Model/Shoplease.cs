using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.Model
{
    /// <summary>
    /// 商铺出租和出售
    /// </summary>
    public class Shoplease
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Sid { get; set; }
        /// <summary>
        /// 封面图片
        /// </summary>
        public string Simg { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Stitle { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string Slabel { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        public int Sregion { get; set; }
        /// <summary>
        /// 建筑面积
        /// </summary>
        public string Sfloorage { get; set; }
        /// <summary>
        /// 月租
        /// </summary>
        public string SMonthlyRent { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public int Ssum { get; set; }
        /// <summary>
        /// 装修
        /// </summary>
        public string SDecoration { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime SUpdatetime { get; set; }
        /// <summary>
        /// 置顶
        /// </summary>
        public string Sstick { get; set; }
        /// <summary>
        /// 状态出租还是出售 
        /// </summary>
        public int States { get; set; }
    }
}

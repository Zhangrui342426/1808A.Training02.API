using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.Model
{
    /// <summary>
    /// 小区表
    /// </summary>
    public class Community
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Cid { get; set; }
        /// <summary>
        /// 封面图片
        /// </summary>
        public string Cimg { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Ctitle { get; set; }
        /// <summary>
        /// 建成时间
        /// </summary>
        public DateTime Ctimes { get; set; }
        /// <summary>
        /// 小区名称、所属小区
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 所属地区
        /// </summary>
        public int Cregion { get; set; }
        /// <summary>
        /// 在售数量
        /// </summary>
        public int Csum { get; set; }
        /// <summary>
        /// 再租数量
        /// </summary>
        public int Csumz { get; set; }
        /// <summary>
        /// 均价
        /// </summary>
        public string CMittelkurs { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool Cstate { get; set; }
    }
}

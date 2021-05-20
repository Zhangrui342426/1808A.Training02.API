using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.Model
{
    /// <summary>
    /// 房源管理
    /// </summary>
    public class Property_manage
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Nid { get; set; }
        /// <summary>
        /// 房源类型外键
        /// </summary>
        public int PropertyId { get; set; }
        /// <summary>
        /// 省市区外键
        /// </summary>11ws 
        public int tb_districtId { get; set; }
        /// <summary>
        /// 小区管理外键
        /// </summary>
        public int CommunityId { get; set; }
        /// <summary>
        /// 开盘时间
        /// </summary>
        public DateTime OpeningTimes { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 开发商
        /// </summary>
        public string Developers { get; set; }
        /// <summary>
        /// 物业公司
        /// </summary>
        public string Propertyfirm { get; set; }
        /// <summary>
        /// 产权年限
        /// </summary>
        public string Propertyyear { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// 地区/地址
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 建筑面积
        /// </summary>
        public string Floorage { get; set; }
        /// <summary>
        /// 均价
        /// </summary>
        public string Mittelkurs { get; set; }
        /// <summary>
        /// 优惠
        /// </summary>
        public string Discounts { get; set; }
        /// <summary>
        /// 楼盘优惠
        /// </summary>
        public string Loupanyh { get; set; }
        /// <summary>
        /// 售房状态
        /// </summary>
        public bool States { get; set; }
        /// <summary>
        /// 户型
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public int Sums { get; set; }
        /// <summary>
        /// 装修
        /// </summary>
        public string Decoration { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime Updatetime { get; set; }
        /// <summary>
        /// 置顶
        /// </summary>
        public string Stick { get; set; }
        /// <summary>
        /// 月租金
        /// </summary>
        public int FMonthlyRent { get; set; }
        /// <summary>
        /// 出售后修改状态
        /// </summary>
        public bool StateChu { get; set; }
    }
}

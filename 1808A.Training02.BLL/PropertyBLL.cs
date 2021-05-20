using _1808A.Training02.DAL;
using _1808A.Training02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _1808A.Training02.BLL
{
    /// <summary>
    /// 房源
    /// </summary>
    public class PropertyBLL
    {
        DBHelper _helper;
        public PropertyBLL(DBHelper helper)
        {
            _helper = helper;
        }
        /// <summary>
        /// 新房显示
        /// </summary>
        /// <returns></returns>
        public List<Property_manage> Property_manageShow()
        {
            string sql = "select * from Property_manage a left join Images b on a.Nid=b.New_HouseId left join Property c on a.PropertyId=c.Pid left join [tb_district] d on  a.tb_districtId=d.id left join Community e on a.CommunityId=e.Cid  where a.PropertyId=1";
            return _helper.GetList<Property_manage>(sql);
        }

        /// <summary>
        /// 二手房显示
        /// </summary>
        /// <returns></returns>
        public List<Property_manage> Resold_apartmentShow()
        {
            string sql = "select * from Property_manage a left join Images b on a.Nid=b.New_HouseId left join Property c on a.PropertyId=c.Pid left join [tb_district] d on  a.tb_districtId=d.id left join Community e on a.CommunityId=e.Cid  where a.PropertyId=2";
            return _helper.GetList<Property_manage>(sql);
        }

        /// <summary>
        /// 出租房显示
        /// </summary>
        /// <returns></returns>
        public List<Property_manage> Rental_housingShow()
        {
            string sql = "select * from Property_manage a left join Images b on a.Nid=b.New_HouseId left join Property c on a.PropertyId=c.Pid left join [tb_district] d on  a.tb_districtId=d.id left join Community e on a.CommunityId=e.Cid  where a.PropertyId=3";
            return _helper.GetList<Property_manage>(sql);
        }
    }
}

using _1808A.Training02.DAL;
using _1808A.Training02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.BLL
{
    /// <summary>
    /// 地区
    /// </summary>
    public class DistrictBLL
    {
        DBHelper _helper;
        public DistrictBLL(DBHelper helper)
        {
            _helper = helper;
        }
        /// <summary>
        /// 省
        /// </summary>
        /// <returns></returns>
        public List<TBDistrict> Getprovince()
        {
            string sql = "select * from tb_district where pid=1 ";
            return _helper.GetList<TBDistrict>(sql);
        }
        /// <summary>
        /// 省
        /// </summary>
        /// <returns></returns>
        public List<TBDistrict> Getcity(int id)
        {
            string sql = $"select * from tb_district where pid={id}";
            return _helper.GetList<TBDistrict>(sql);
        }
    }
}

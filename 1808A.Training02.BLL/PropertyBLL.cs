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
        #region 新房
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
        /// 新房添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Property_Insert(Property_manage p)
        {
            string sql = $"insert into Property_manage values ('1','{p.tb_districtId}','{p.CommunityId}','{p.OpeningTimes}','{p.Title}','{p.Developers}','{p.Propertyfirm}','{p.Propertyyear}','{p.Label}','{p.Region}','{p.Floorage}','{p.Mittelkurs}','{p.Discounts}','{p.Loupanyh}',{p.States},'{p.Unit}','{p.Sums}','{p.Decoration}',getdate(),'{p.Stick}','{p.FMonthlyRent}',{(p.StateChu ? 1 : 0)})";
            return _helper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 二手房
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
        /// 二手房添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Resold_Insert(Property_manage p)
        {
            string sql = $"insert into Property_manage values ('2','{p.tb_districtId}','{p.CommunityId}','{p.OpeningTimes}','{p.Title}','{p.Developers}','{p.Propertyfirm}','{p.Propertyyear}','{p.Label}','{p.Region}','{p.Floorage}','{p.Mittelkurs}','{p.Discounts}','{p.Loupanyh}',{p.States},'{p.Unit}','{p.Sums}','{p.Decoration}',getdate(),'{p.Stick}','{p.FMonthlyRent}',{(p.StateChu ? 1 : 0)})";
            return _helper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 出租房
        /// <summary>
        /// 出租房显示
        /// </summary>
        /// <returns></returns>
        public List<Property_manage> Rental_housingShow()
        {
            string sql = "select * from Property_manage a left join Images b on a.Nid=b.New_HouseId left join Property c on a.PropertyId=c.Pid left join [tb_district] d on  a.tb_districtId=d.id left join Community e on a.CommunityId=e.Cid  where a.PropertyId=3";
            return _helper.GetList<Property_manage>(sql);
        }
        /// <summary>
        /// 出租房添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Rental_Insert(Property_manage p)
        {
            string sql = $"insert into Property_manage values ('3','{p.tb_districtId}','{p.CommunityId}','{p.OpeningTimes}','{p.Title}','{p.Developers}','{p.Propertyfirm}','{p.Propertyyear}','{p.Label}','{p.Region}','{p.Floorage}','{p.Mittelkurs}','{p.Discounts}','{p.Loupanyh}',{p.States},'{p.Unit}','{p.Sums}','{p.Decoration}',getdate(),'{p.Stick}','{p.FMonthlyRent}',{(p.StateChu ? 1 : 0)})";
            return _helper.ExecuteNonQuery(sql);
        }
        #endregion
        /// <summary>
        /// 删除房
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Delete(string ids)
        {
            ids = ids.TrimEnd(',');
            string sql = $"delete from Property_manage where Nid in ({ids})";
            return _helper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Property_manage GetProperty(int id)
        {
            string sql = $"select * from Property_manage where Nid={id}";
            return _helper.Get<Property_manage>(sql);
        }

        /// <summary>
        /// 修改房
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Update(Property_manage p)
        {
            string sql = $"update Property_manage set tb_districtId={p.tb_districtId},CommunityId={p.CommunityId},OpeningTimes='{p.OpeningTimes}',Title='{p.Title}',Developers='{p.Developers}',Propertyfirm='{p.Propertyfirm}',Propertyyear='{p.Propertyyear}',Label = '{p.Label}',Region = '{p.Region}',Floorage = '{p.Floorage}',Mittelkurs = '{p.Mittelkurs}',Discounts = '{p.Discounts}',Loupanyh = '{p.Loupanyh}',States = {(p.States?1:0)},Unit = '{p.Unit}',Sums = {p.Sums},Decoration = '{p.Decoration}',Updatetime = '{p.Updatetime}',Stick = '{p.Stick}',FMonthlyRent = '{p.FMonthlyRent}',StateChu = {(p.StateChu?1:0)} where Nid = {p.Nid}";
            return _helper.ExecuteNonQuery(sql);
        }

    }
}

using _1808A.Training02.DAL;
using _1808A.Training02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.BLL
{
    public class ShopleaseBLL
    {
        DBHelper _helper;
        public ShopleaseBLL(DBHelper helper)
        {
            _helper = helper;
        }
        /// <summary>
        /// 商铺出租显示
        /// </summary>
        /// <returns></returns>
        public List<Shoplease> GetShoplease()
        {
            string sql = "select * from Shop_lease";
            return _helper.GetList<Shoplease>(sql);
        }
        /// <summary>
        /// 商铺添加
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Insert(Shoplease s)
        {
            string sql = $"insert into Shop_lease values('{s.Simg}','{s.Stitle}','{s.Slabel}',{s.Sregion},'{s.Sfloorage}','{s.SMonthlyRent}',{s.Ssum},'{s.SDecoration}','{s.SUpdatetime}','{s.Sstick}',{s.States})";
            return _helper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除商铺
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Delete(string ids)
        {
            ids = ids.TrimEnd(',');
            string sql = $"delete from Shop_lease where Sid in ({ids})";
            return _helper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Shoplease Fan(int id)
        {
            string sql = $"select * from Shop_lease where Sid={id}";
            return _helper.Get<Shoplease>(sql);
        }

        /// <summary>
        /// 修改商铺
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Update(Shoplease s)
        {
            string sql = $"update Shop_lease set Simg='{s.Simg}',Stitle='{s.Stitle}',Slabel='{s.Slabel}',Sregion={s.Sregion},Sfloorage='{s.Sfloorage}',SMonthlyRent='{s.SMonthlyRent}',Ssum={s.Ssum},SDecoration='{s.SDecoration}',SUpdatetime='{s.SUpdatetime}',Sstick='{s.Sstick}',States={s.States}";
            return _helper.ExecuteNonQuery(sql);
        }
    }
}

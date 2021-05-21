using _1808A.Training02.DAL;
using _1808A.Training02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.BLL
{
    public class CommunityBLL
    {
        DBHelper _helper;
        public CommunityBLL(DBHelper helper)
        {
            _helper = helper;
        }
        /// <summary>
        /// 小区显示
        /// </summary>
        /// <returns></returns>
        public List<Community> GetCommunity()
        {
            string sql = "select * from Community";
            return _helper.GetList<Community>(sql);
        }
        /// <summary>
        /// 小区添加
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Insert(Community c)
        {
            string sql = $"insert into Community values('{c.Cimg}','{c.Ctitle}','{c.Ctimes}','{c.CName}','{c.Cregion}','{c.Csum}','{c.Csumz}','{c.CMittelkurs}','{(c.Cstate?1:0)}')";
            return _helper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除小区
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int Delete(string ids)
        {
            ids = ids.TrimEnd(',');
            string sql = $"delete from Community where Cid in ({ids})";
            return _helper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Community Fan(int id)
        {
            string sql = $"select * from Community where Cid={id}";
            return _helper.Get<Community>(sql);
        }

        /// <summary>
        /// 修改房
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Update(Community c)
        {
            string sql = $"update Community set Cimg='{c.Cimg}',Ctitle='{c.Ctitle}',Ctimes='{c.Ctimes}',CName='{c.CName}',Cregion={c.Cregion},Csum={c.Csum},Csumz={c.Csumz},CMittelkurs='{c.CMittelkurs}',Cstate={(c.Cstate ? 1 : 0)}";
            return _helper.ExecuteNonQuery(sql);
        }
    }
}

using _1808A.Training02.DAL;
using _1808A.Training02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.BLL
{
    public class AdministratorBLL
    {
        DBHelper _helper;
        public AdministratorBLL(DBHelper helper)
        {
            _helper = helper;
        }
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public List<Administrator> AdminLogin(Administrator t)
        {
            string sql = $"select * from Administrator where Aname='{t.Aname}' and Apasswork='{t.Apasswork}'";
            return _helper.GetList<Administrator>(sql);

        }
    }
}

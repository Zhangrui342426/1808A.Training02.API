using _1808A.Training02.DAL;
using _1808A.Training02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1808A.Training02.BLL
{
   public class UserBLL
    {
        DBHelper _helper;
        public UserBLL(DBHelper helper)
        {
            _helper = helper;
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public List<Users> UserLogin(Users u)
        {
            string sql = $"select * from Users where uname='{u.Uname}' and Upasswork='{u.Upasswork}'";
            return _helper.GetList<Users>(sql);

        }
    }
}

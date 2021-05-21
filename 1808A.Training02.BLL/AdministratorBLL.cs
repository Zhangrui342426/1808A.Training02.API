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
        public List<Administrator> AdminLogin(Administrator a)
        {
            string sql = $"select * from Administrator where Aname='{a.Aname}' and Apasswork='{a.Apasswork}'";
            return _helper.GetList<Administrator>(sql);
        }
    }
}

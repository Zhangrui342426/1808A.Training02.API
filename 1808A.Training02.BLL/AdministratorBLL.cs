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
        public List<TBAdministrator> AdminLogin(TBAdministrator t)
        {
            string sql = $"select * from tb_administrator where adminname='{t.AdminName} and adminpassword='{t.AdminPassword}'";
            return _helper.GetList<TBAdministrator>(sql);

        }
    }
}

using _1808A.Training02.BLL;
using _1808A.Training02.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1808A.Training02.API.Controllers
{
    [ApiController]
    [Route("API/AdminLogin")]
    public class AdminLoginController : Controller
    {
        AdministratorBLL _bll;
        public AdminLoginController(AdministratorBLL bll)
        {
            _bll = bll;
        }
        [Route("AdminLogin"),HttpPost]
        public IActionResult Login(TBAdministrator t)
        {
            int h = _bll.AdminLogin(t).Count();
            return Ok(new { data=h,msg=h>0?"登录成功":"用户名不存在或密码输入错误"});
        }
    }
}

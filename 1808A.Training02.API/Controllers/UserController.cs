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
    [Route("API/User")]
    public class UserController : Controller
    {
        UserBLL _bll;
        public UserController(UserBLL bll)
        {
            _bll = bll;
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [Route("UserLogin"), HttpPost]
        public IActionResult UserLogin(Users u)
        {
            int h = _bll.UserLogin(u).Count();
            return Ok(new { data = h, msg = h > 0 ? "登录成功" : "用户名不存在或密码输入错误" });
        }
    }
}

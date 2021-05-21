using _1808A.Training02.BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1808A.Training02.API.Controllers
{
    [ApiController]
    [Route("API/District")]
    public class DistrictController : Controller
    {
        DistrictBLL _bll;
        public DistrictController(DistrictBLL bll)
        {
            _bll = bll;
        }
        /// <summary>
        /// 省
        /// </summary>
        /// <returns></returns>
        [Route("Getprovince"),HttpGet]
        public IActionResult Getprovince()
        {
            var list = _bll.Getprovince();
            return Ok(new { data=list});
        }
        [Route("Getcity"), HttpGet]
        public IActionResult Getcity(int id)
        {
            var list = _bll.Getcity(id);
            return Ok(new { data = list });
        }
    }
}

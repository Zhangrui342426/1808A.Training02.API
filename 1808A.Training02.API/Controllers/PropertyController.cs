using _1808A.Training02.BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1808A.Training02.API.Controllers
{
    [ApiController]
    [Route("API/Property")]
    public class PropertyController : Controller
    {
        PropertyBLL _bll;
        public PropertyController(PropertyBLL bll)
        {
            _bll = bll;
        }
        /// <summary>
        /// 新房显示
        /// </summary>
        /// <returns></returns>
        [Route("Property"), HttpGet]
        public IActionResult Property_manageShow()
        {
            var list = _bll.Property_manageShow();
            return Ok(new { data = list});
        }
        /// <summary>
        /// 二手房显示
        /// </summary>
        /// <returns></returns>
        [Route("Resold"), HttpGet]
        public IActionResult Resold_apartmentShow()
        {
            var list = _bll.Resold_apartmentShow();
            return Ok(new { data = list });
        }
        /// <summary>
        /// 出租房显示
        /// </summary>
        /// <returns></returns>
        [Route("Renta"), HttpGet]
        public IActionResult Rental_housingShow()
        {
            var list = _bll.Rental_housingShow();
            return Ok(new { data = list });
        }
    }
}

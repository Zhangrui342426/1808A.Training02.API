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
        /// 新房添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
         [Route("Property_Insert"), HttpPost]
        public IActionResult Property_Insert(Property_manage p)
        {
            int h = _bll.Property_Insert(p);
            return Ok(new { data = h,sate=h>0?true:false,msg=h>0?"添加成功":"添加失败" });
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
        /// 二手房添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Resold_Insert"), HttpPost]
        public IActionResult Resold_Insert(Property_manage p)
        {
            int h = _bll.Resold_Insert(p);
            return Ok(new { data = h, sate = h > 0 ? true : false, msg = h > 0 ? "添加成功" : "添加失败" });
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
        /// <summary>
        /// 出租房添加
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Rental_Insert"), HttpPost]
        public IActionResult Rental_Insert(Property_manage p)
        {
            int h = _bll.Rental_Insert(p);
            return Ok(new { data = h, sate = h > 0 ? true : false, msg = h > 0 ? "添加成功" : "添加失败" });
        }
        /// <summary>
        /// 房删除
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Delete"), HttpPost]
        public IActionResult Delete(string ids)
        {
            int h = _bll.Delete(ids);
            return Ok(new { data = h, sate = h > 0 ? true : false, msg = h > 0 ? "删除成功" : "删除失败" });
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetProperty"), HttpGet]
        public IActionResult GetProperty(int id)
        {
            var llst = _bll.GetProperty(id);
            return Ok(new { data = llst});
        }
        /// <summary>
        /// 修改房
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Update"), HttpPost]
        public IActionResult Update(Property_manage p)
        {
            int h = _bll.Update(p);
            return Ok(new { data = h, sate = h > 0 ? true : false, msg = h > 0 ? "编辑成功" : "编辑失败" });
        }
    }
}

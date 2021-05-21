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
    [Route("API/Community")]
    public class CommunityController : Controller
    {
        CommunityBLL _bll;
        public CommunityController(CommunityBLL bll)
        {
            _bll = bll;
        }
        /// <summary>
        /// 小区显示
        /// </summary>
        /// <returns></returns>
        [Route("GetCommunity"), HttpGet]
        public IActionResult GetCommunity()
        {
            var list = _bll.GetCommunity();
            return Ok(new { data = list });
        }
       /// <summary>
       /// 小区添加
       /// </summary>
       /// <param name="p"></param>
       /// <returns></returns>
        [Route("Insert"), HttpPost]
        public IActionResult Insert(Community c)
        {
            int h = _bll.Insert(c);
            return Ok(new { data = h, sate = h > 0 ? true : false, msg = h > 0 ? "添加成功" : "添加失败" });
        }
        /// <summary>
        /// 房删除
        /// </summary>
        /// <param name="ids"></param>
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
        [Route("Fan"), HttpGet]
        public IActionResult Fan(int id)
        {
            var llst = _bll.Fan(id);
            return Ok(new { data = llst });
        }
        /// <summary>
        /// 修改房
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [Route("Update"), HttpPost]
        public IActionResult Update(Community c)
        {
            int h = _bll.Update(c);
            return Ok(new { data = h, sate = h > 0 ? true : false, msg = h > 0 ? "编辑成功" : "编辑失败" });
        }
    }
}

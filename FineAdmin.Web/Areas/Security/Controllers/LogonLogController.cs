﻿using FineAdmin.IService;
using FineAdmin.Model;
using FineAdmin.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace FineAdmin.Web.Areas.Security.Controllers
{
    [Area("Security")]
    public class LogonLogController : BaseController
    {
        public ILogonLogService LogonLogService { get; set; }
        // GET: Security/LogonLog
        //这里Index其实可以省略，不省略的话就重写父类，吧菜单Id传过去
        public override ActionResult Index(int? id)
        {
            base.Index(id);
            return View();
        }
        [HttpGet]
        public JsonResult List(LogonLogModel model, PageInfo pageInfo)
        {
            var result = LogonLogService.GetListByFilter(model, pageInfo);
            return Json(result);
        }
        [HttpGet]
        public JsonResult Delete(int id)
        {
            var result = LogonLogService.DeleteById(id) ? SuccessTip("删除成功") : ErrorTip("删除失败");
            return Json(result);
        }
        [HttpGet]
        public JsonResult BatchDel(string idsStr)
        {
            var idsArray = idsStr.Substring(0, idsStr.Length - 1).Split(',');
            var result = LogonLogService.DeleteByIds(idsArray) ? SuccessTip("批量删除成功") : ErrorTip("批量删除失败");
            return Json(result);
        }
    }
}
using FineAdmin.IService;
using FineAdmin.Model;
using FineAdmin.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FineAdmin.Web.Areas.Permissions.Controllers
{
    [Area("Permissions")]
    public class ModuleController : BaseController
    {
        public IModuleService ModuleService { get; set; }
        // GET: Permissions/Module
        public override ActionResult Index(int? id)
        {
            base.Index(id);
            return View();
        }
        [HttpGet]
        public JsonResult List() 
        {
            var list = ModuleService.GetAll();
            var result = new { code = 0, count = list.Count(), data = list };
            return Json(result);
        }
        [HttpGet]
        public JsonResult GetModuleList()
        {
            object result = ModuleService.GetModuleList(Operator.RoleId);
            return Json(result);
        }
        [HttpGet]
        public JsonResult GetModuleTreeSelect()
        {
            var result = ModuleService.GetModuleTreeSelect();
            return Json(result);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Add(ModuleModel model)
        {
            model.FontFamily = "ok-icon";
            model.CreateTime = DateTime.Now;
            model.CreateUserId = Operator.UserId;
            model.UpdateTime = DateTime.Now;
            model.UpdateUserId = Operator.UserId;
            var result = ModuleService.Insert(model) ? SuccessTip("添加成功") : ErrorTip("添加失败");
            return Json(result);
        }
        public ActionResult Edit(int id)
        {
            var model = ModuleService.GetById(id);
            return View(model);
        }
        [HttpPost]
        
        public ActionResult Edit(ModuleModel model)
        {
            model.UpdateTime = DateTime.Now;
            model.UpdateUserId = Operator.UserId;
            var result = ModuleService.UpdateById(model) ? SuccessTip("修改成功") : ErrorTip("修改失败");
            return Json(result);
        }
        [HttpGet]
        public JsonResult Delete(int id)
        {
            var result = ModuleService.DeleteById(id) ? SuccessTip("删除成功") : ErrorTip("删除失败");
            return Json(result);
        }
        /// <summary>
        /// 根据角色ID获取模块和模块按钮
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult ModuleButtonList(int roleId)
        {
            var list = ModuleService.GetModuleButtonList(roleId).OrderBy(x => x.ParentId);
            var result = new { code = 0, count = list.Count(), data = list };
            return Json(result);
        }
    }
}
﻿using FineAdmin.IService;
using FineAdmin.Model;
using FineAdmin.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FineAdmin.Web.Areas.Permissions.Controllers
{
    [Area("Permissions")]
    public class ItemsController : BaseController
    {
        public IItemsService ItemsService { get; set; }
        // GET: Permissions/Items
        public override ActionResult Index(int? id)
        {
            base.Index(id);
            return View();
        }
        [HttpGet]
        public JsonResult List()
        {
            var list = ItemsService.GetAll();
            var result = new { code = 0, count = list.Count(), data = list };
            return Json(result);
        }
        [HttpGet]
        public JsonResult GetItemsTreeSelect()
        {
            var result = ItemsService.GetItemsTreeSelect();
            return Json(result);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(ItemsModel model)
        {
            model.CreateTime = DateTime.Now;
            model.CreateUserId = Operator.UserId;
            model.UpdateTime = DateTime.Now;
            model.UpdateUserId = Operator.UserId;
            var result = ItemsService.Insert(model) ? SuccessTip("添加成功") : ErrorTip("添加失败");
            return Json(result);
        }
        public ActionResult Edit(int id)
        {
            var model = ItemsService.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ItemsModel model)
        {
            model.UpdateTime = DateTime.Now;
            model.UpdateUserId = Operator.UserId;
            var result = ItemsService.UpdateById(model) ? SuccessTip("修改成功") : ErrorTip("修改失败");
            return Json(result);
        }
        [HttpGet]
        public JsonResult Delete(int id)
        {
            var result = ItemsService.DeleteById(id) ? SuccessTip("删除成功") : ErrorTip("删除失败");
            return Json(result);
        }

    }
}
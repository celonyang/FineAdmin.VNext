﻿using FineAdmin.IService;
using FineAdmin.Model;
using FineAdmin.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace FineAdmin.Web.Areas.Permissions.Controllers
{
    [Area("Permissions")]
    public class OrganizeController : BaseController
    {
        public IOrganizeService OrganizeService { get; set; }
        public IItemsDetailService ItemsDetailService { get; set; }

        public SelectList CategoryNameList { get { return new SelectList(ItemsDetailService.GetAll("Id,ItemName,ItemId", "ORDER BY SortCode ASC").Where(x => x.ItemId == 2), "Id", "ItemName"); } }

        // GET: Permissions/Organize
        public override ActionResult Index(int? id)
        {
            base.Index(id);
            return View();
        }
        [HttpGet]
        public JsonResult List()
        {
            var list = OrganizeService.GetOrganizeList().OrderBy(O=>O.ParentId);
            var result = new { code = 0, count = list.Count(), data = list };
            return Json(result);
        }
        [HttpGet]
        public JsonResult GetOrganizeTreeSelect() 
        {
            var result = OrganizeService.GetOrganizeTreeSelect();
            return Json(result);
        }
        public ActionResult Add()
        {
            ViewBag.CategoryNameList = CategoryNameList;
            return View();
        }
        [HttpPost]
        public ActionResult Add(OrganizeModel model)
        {
            model.CreateTime = DateTime.Now;
            model.CreateUserId = Operator.UserId;
            model.UpdateTime = DateTime.Now;
            model.UpdateUserId = Operator.UserId;
            var result = OrganizeService.Insert(model) ? SuccessTip("添加成功") : ErrorTip("添加失败");
            return Json(result);
        }
        public ActionResult Edit(int id)
        {
            ViewBag.CategoryNameList = CategoryNameList;
            var model = OrganizeService.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(OrganizeModel model)
        {
            model.UpdateTime = DateTime.Now;
            model.UpdateUserId = Operator.UserId;
            var result = OrganizeService.UpdateById(model) ? SuccessTip("修改成功") : ErrorTip("修改失败");
            return Json(result);
        }
        [HttpGet]
        public JsonResult Delete(int id)
        {
            var result = OrganizeService.DeleteById(id) ? SuccessTip("删除成功") : ErrorTip("删除失败");
            return Json(result);
        }

    }
}
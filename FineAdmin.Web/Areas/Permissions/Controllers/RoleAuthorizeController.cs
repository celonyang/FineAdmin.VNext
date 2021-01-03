﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FineAdmin.Web.Controllers;
using FineAdmin.IService;
using FineAdmin.Model;
using Microsoft.AspNetCore.Mvc;

namespace FineAdmin.Web.Areas.Permissions.Controllers
{
    [Area("Permissions")]
    public class RoleAuthorizeController : BaseController
    {
        public IRoleAuthorizeService RoleAuthorizeService { get; set; }

        // GET: Permissions/RoleAuthorize
        public override ActionResult Index(int? id)
        {
            base.Index(id);
            return View();
        }

        [HttpPost]
        public ActionResult InsertBatch(IEnumerable<RoleAuthorizeModel> list, int roleId)
        {
            var result = RoleAuthorizeService.SavePremission(list, roleId) > 0 ? SuccessTip("保存成功") : ErrorTip("保存失败");
            return Json(result);
        }
    }
}
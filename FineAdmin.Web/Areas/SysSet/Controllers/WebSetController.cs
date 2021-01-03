using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FineAdmin.Web.Controllers;
using FineAdmin.Web.Areas.SysSet.Models;
using Microsoft.AspNetCore.Mvc;

namespace FineAdmin.Web.Areas.SysSet.Controllers
{
    [Area("SysSet")]
    public class WebSetController : BaseController
    {
        // GET: SysSet/WebSet
        public override ActionResult Index(int? id)
        {
            return View(new WebModel().GetWebInfo());
        }
        [HttpPost]
        public ActionResult Index(WebModel model) 
        {
            try
            {
                new WebModel().SetWebInfo(model);
            }
            catch (Exception ex)
            {
                ViewBag.Msg = "Error:"+ex.Message;
                return View(new WebModel().GetWebInfo());
            }
            ViewBag.Msg = "修改成功！";
            return View(new WebModel().GetWebInfo());
        }
    }
}
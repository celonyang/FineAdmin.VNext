using FineAdmin.Web.Areas.SysSet.Models;
using FineAdmin.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FineAdmin.Web.Areas.SysSet.Controllers
{
    [Area("SysSet")]
    public class DevSetController : BaseController
    {
        // GET: SysSet/DevSet
        public override ActionResult Index(int? id)
        {
            return View(new DevModel().GetDevInfo());
        }
        [HttpPost]
        public ActionResult Index(DevModel model)
        {
            try
            {
                new DevModel().SetDevInfo(model);
            }
            catch (Exception ex)
            {
                ViewBag.Msg = "Error:" + ex.Message;
                return View(new DevModel().GetDevInfo());
            }
            ViewBag.Msg = "修改成功！";
            return View(new DevModel().GetDevInfo());
        }
    }
}
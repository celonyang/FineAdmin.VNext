using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using FineAdmin.Web.Areas.SysSet.Models;
using FineAdmin.Model;
using FineAdmin.Common;
using System.IO;
using FineAdmin.IService;
using Microsoft.AspNetCore.Hosting;

namespace FineAdmin.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IWebHostEnvironment WebHostEnvironment { get; set; }
        public override ActionResult Index(int? id)
        {
            ViewBag.Account = Operator == null ? "" : Operator.RealName;
            ViewBag.HeadIcon = Operator == null ? "" : Operator.HeadIcon;
            return View(new WebModel().GetWebInfo());
        }

        public ActionResult Main()
        {
            return View();
        }

        public JsonResult ExportFile()
        {
            UploadFile uploadFile = new UploadFile();
            try
            {
                var file = Request.Form.Files[0];    //获取选中文件
                var filecombin = file.FileName.Split('.');
                if (file == null || string.IsNullOrEmpty(file.FileName) || file.Length == 0 || filecombin.Length < 2)
                {
                    uploadFile.code = -1;
                    uploadFile.src = "";
                    uploadFile.msg = "上传出错!请检查文件名或文件内容";
                    return Json(uploadFile);
                }
                //定义本地路径位置
                string localPath = WebHostEnvironment.WebRootPath + @"/Upload";
                string filePathName = string.Empty; //最终文件名
                filePathName = Common.Common.CreateNo() + "." + filecombin[1];
                //Upload不存在则创建文件夹
                if (!System.IO.Directory.Exists(localPath))
                {
                    System.IO.Directory.CreateDirectory(localPath);
                }
                using (FileStream fs = System.IO.File.Create(Path.Combine(localPath, filePathName)))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }  //保存图片
                uploadFile.code = 0;
                uploadFile.src = Path.Combine("/Upload/", filePathName);
                uploadFile.msg = "上传成功";
                return Json(uploadFile);
            }
            catch (Exception)
            {
                uploadFile.code = -1;
                uploadFile.src = "";
                uploadFile.msg = "上传出错!程序异常";
                return Json(uploadFile);
            }
        }

    }
}
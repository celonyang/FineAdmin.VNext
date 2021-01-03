using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using FineAdmin.Common;
using FineAdmin.IService;
using FineAdmin.Model;
using FineAdmin.Web.Areas.SysSet.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace FineAdmin.Web.Controllers
{
    public class LoginController : Controller
    {
        public IHttpContextAccessor httpContextAccessor { get; set; }
        public IUserService UserService { get; set; }
        public ILogonLogService LogonLogService { get; set; }

        public ILogger<LoginController> Logger { set; get; }
        // GET: Login
        public ActionResult Index()
        {
            return View(new WebModel().GetWebInfo());
        }
        [HttpGet]
        public ActionResult GetAuthCode()
        {
            try
            {
                Logger.LogInformation("获取验证码");
                return File(new VerifyCode(HttpContext).GetVerifyCode(), @"image/Gif");
            }
            catch (Exception e)
            {
                Logger.LogError($"获取验证码异常:{e}");
                throw;
            }
        }
        [HttpPost]
        public ActionResult LoginOn(string username, string password, string captcha)
        {
            LogonLogModel logEntity = new LogonLogModel();
            var OperatorProvider = new OperatorProvider(HttpContext);
            logEntity.LogType = DbLogType.Login.ToString();
            try
            {
                if (OperatorProvider.WebHelper.GetSession("session_verifycode").IsEmpty() || Md5.md5(captcha.ToLower(), 16) != OperatorProvider.WebHelper.GetSession("session_verifycode"))
                {
                    throw new Exception("验证码错误");
                }
                UserModel userEntity = UserService.LoginOn(username, Md5.md5(password, 32));
                if (userEntity != null)
                {
                    if (userEntity.EnabledMark == 1)
                    {
                        throw new Exception("账号被锁定，禁止登录");
                    }
                    OperatorModel operatorModel = new OperatorModel();
                    operatorModel.UserId = userEntity.Id;
                    operatorModel.Account = userEntity.Account;
                    operatorModel.RealName = userEntity.RealName;
                    operatorModel.HeadIcon = userEntity.HeadIcon;
                    operatorModel.RoleId = userEntity.RoleId;
                    operatorModel.LoginIPAddress = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
                    operatorModel.LoginIPAddressName = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
                    OperatorProvider.AddCurrent(operatorModel);
                    logEntity.Account = userEntity.Account;
                    logEntity.RealName = userEntity.RealName;
                    logEntity.Description = "登陆成功";
                    LogonLogService.WriteDbLog(logEntity, operatorModel.LoginIPAddress, operatorModel.LoginIPAddressName);
                    return Content(new AjaxResult { state = ResultType.success.ToString(), message = "登录成功" }.ToJson());
                }
                else
                {
                    throw new Exception("用户名或密码错误");
                }
            }
            catch (Exception ex)
            {
                logEntity.Account = username;
                logEntity.RealName = username;
                logEntity.Description = "登录失败，" + ex.Message;
                LogonLogService.WriteDbLog(logEntity, HttpContext.Connection.RemoteIpAddress.ToString(), HttpContext.Connection.RemoteIpAddress.ToString());
                return Content(new AjaxResult { state = ResultType.error.ToString(), message = ex.Message }.ToJson());
            }
        }
        [HttpGet]
        public ActionResult LoginOut()
        {
            var OperatorProvider = new OperatorProvider(HttpContext);
            LogonLogService.WriteDbLog(new LogonLogModel
            {
                LogType = DbLogType.Exit.ToString(),
                Account = OperatorProvider.GetCurrent().Account,
                RealName = OperatorProvider.GetCurrent().RealName,
                Description = "安全退出系统",
            }, HttpContext.Connection.RemoteIpAddress.ToString(), HttpContext.Connection.RemoteIpAddress.ToString());
            OperatorProvider.WebHelper.ClearSession();
            OperatorProvider.RemoveCurrent();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Error()
        {

            ViewData["StatusCode"] = HttpContext.Response.StatusCode;
            return View();
        }
    }
}
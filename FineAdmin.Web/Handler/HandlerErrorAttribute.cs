using FineAdmin.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FineAdmin.Web
{
    /// <summary>
    /// 异常Attribute
    /// </summary>
    public class HandlerErrorAttribute :  Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.ExceptionHandled = true;
            context.HttpContext.Response.StatusCode = 200;
            context.Result = new ContentResult { Content = new AjaxResult { state = ResultType.error.ToString(), message = context.Exception.Message }.ToJson() };
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}
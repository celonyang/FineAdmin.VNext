using FineAdmin.Common;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FineAdmin.Web
{
    /// <summary>
    /// 授权验证Attribute
    /// </summary>
    public class HandlerLoginAttribute : Attribute, IActionFilter
    {
        public bool Ignore = true;

        public HandlerLoginAttribute(bool ignore = true)
        {
            Ignore = ignore;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (Ignore == false)
            {
                return;
            }
            if (new OperatorProvider(context.HttpContext).GetCurrent() == null)
            {
                context.HttpContext.Response.Redirect("/Login");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
          
        }
    }
}
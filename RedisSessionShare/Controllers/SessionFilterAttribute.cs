using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedisSessionShare.Module;

namespace RedisSessionShare.Controllers
{
    public class SessionFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 每次请求都续期
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            new Session(filterContext.HttpContext).Postpone();
        }
    }
}
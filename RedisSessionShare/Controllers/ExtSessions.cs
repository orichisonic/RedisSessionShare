using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedisSessionShare.Module;

namespace RedisSessionShare.Controllers
{
    public static class ExtSessions
    {
        public static Session SessionExt(this HttpContextBase context)
        {
            return new Session(context);
        }

        public static Session SessionExt(this Controller controller)
        {
            return new Session(controller.HttpContext);
        }
    }
}
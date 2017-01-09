using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedisSessionShare.Controllers
{
    public class test
    {
        public string name { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Index()
        {
            var t = this.SessionExt().Get<test>();

            return View(t);
        }

        public ActionResult Login(string name)
        {
            test t = new test() { name = name };

            //登录
            this.SessionExt().Login<test>(t);

            return this.RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspnetMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()//listeleme metotu
        {
            return View();
        }

        public ActionResult About()//hakkında metotu
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()//iletişim metotu
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}
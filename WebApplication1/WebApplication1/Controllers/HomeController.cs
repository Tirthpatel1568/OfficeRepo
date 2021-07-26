using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration =100)]
        public ActionResult Index()
        {
            TempData["name"] = "tirth";
            return View();
        }

        public ActionResult About()
        {
            string name;
            if (TempData.ContainsKey("name"))
                name = TempData["name"].ToString();
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //string msg = null;
            ViewBag.Message = "Your contact page.";
            //ViewBag.Message = msg.Length;
            return View();
        }
        [ChildActionOnly]
        public ActionResult RenderMenu()
        {
            return PartialView("_MenuBar");
        }
    }
}

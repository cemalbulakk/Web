using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanzHow.Controllers
{
    public class OtherPagesController : Controller
    {
        // GET: OtherPages
        public ActionResult Full()
        {
            return View();
        }
        public ActionResult SidebarPage()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult _404()
        {
            return View();
        }
    }
}
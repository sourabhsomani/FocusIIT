using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARNFocusIIT.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/
        public ActionResult Index()
        {
            return RedirectToAction("Introduction");
        }
        public ActionResult Introduction()
        {
            return View();
        }
	}
}
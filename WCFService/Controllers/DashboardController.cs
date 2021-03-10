using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WCFService.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashborad
        public ActionResult Index()
        {
            return View();
        }
    }
}
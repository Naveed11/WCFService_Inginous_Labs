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
            
            MachineEyes.MachineEyesServiceClient client = new MachineEyes.MachineEyesServiceClient();
            MachineEyes.Sheds[] s = client.Get_Sheds("adfadf");
            ViewBag.Shed = s;
            return View();
        }
    }
}
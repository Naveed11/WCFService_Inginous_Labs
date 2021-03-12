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

        public void MachineEyes()
        {
            MachineEyes.MachineEyesServiceClient client = new MachineEyes.MachineEyesServiceClient();
            MachineEyes.Sheds[] s = client.Get_Sheds("adfadf");
            ViewBag.Shed = s;
        }
        //public void ChangeRequestURL()
        //{
        //    string fullUrl = Request.Url.ToString();
        //    if (fullUrl.Contains("/Dashboard/Setting"))
        //    {
        //        Content.RewritePath("/Dashboard/Index");
        //    }
        //}
        public ActionResult Index()
        {
            MachineEyes();
            return View();
        }

        public ActionResult Setting()
        {
            MachineEyes();
            return View();
        }

    }
}
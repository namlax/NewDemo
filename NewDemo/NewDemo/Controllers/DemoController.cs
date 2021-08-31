using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult TinhTong()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TinhTong(string soA, string soB)
        {
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            return View();
        }
    }
}
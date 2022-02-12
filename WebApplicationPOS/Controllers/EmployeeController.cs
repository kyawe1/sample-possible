using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPOS.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FindProduct()
        {
            //this must be json
            return RedirectToAction("Index","Home");
        }
        
        //public ActionResult CheckOut(Order order)
        //{
            
        //}
    }
}
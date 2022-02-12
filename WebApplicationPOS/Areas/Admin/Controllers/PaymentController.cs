using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPOS.Areas.Admin.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Admin/Payment
        public ActionResult Index()
        {
            return View();
        }
    }
}
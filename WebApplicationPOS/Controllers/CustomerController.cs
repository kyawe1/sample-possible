using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationPOS.Models;
using Core.Entity;
using Application.Repository;

namespace WebApplicationPOS.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include ="Name,Phone,Address")]ConsumerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Consumer consumer = new Consumer()
                {
                    Consumer_Address=viewModel.Address,
                    Consumer_Phone=viewModel.Phone,
                    Consumer_Name=viewModel.Name,
                };
                using (var repo=new ConsumerRespository())
                {
                    repo.insert(consumer);
                }
                return RedirectToAction("Index", "Home");
            }
            return View(viewModel);
        }
        
    }
}
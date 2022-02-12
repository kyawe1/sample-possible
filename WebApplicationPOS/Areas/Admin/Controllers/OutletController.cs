using Application.Repository;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationPOS.Models;

namespace WebApplicationPOS.Areas.Admin.Controllers
{
    public class OutletController : Controller
    {
        // GET: Admin/Outlet
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(OutletViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var model = new Outlet()
                {
                    Outlet_Address=viewModel.Address,
                    Outlet_Name=viewModel.Name,
                    Platform=viewModel.Platform
                };
                using(var context = new OutletRepository())
                {
                    context.insert(model);
                    return RedirectToAction("Index");
                }
            }
            return View(viewModel);
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(int Id,OutletViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var model = new Outlet()
                {
                    Outlet_Address=viewModel.Address,
                    Outlet_Name=viewModel.Name,
                    Platform=viewModel.Platform
                };
                using(var context = new OutletRepository())
                {
                    context.update(Id,model);
                    return RedirectToAction("Index");
                }
            }
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Delete(int Id,OutletViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                using(var context = new OutletRepository())
                {
                    var model = context.whereById(Id);
                    context.delete(model);
                    return RedirectToAction("Index");
                }
            }
            return View(viewModel);
        }
    }
}
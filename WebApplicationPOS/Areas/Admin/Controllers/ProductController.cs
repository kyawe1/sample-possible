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
    [RouteArea("Admin")]
    public class ProductController : Controller
    {
        // GET: Admin/Product
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
        public ActionResult Create([Bind(Include ="Name,Description,Price")]ProductViewModel viewModel)
        {
            if (ModelState.IsValid) 
            {
                Product n = new Product()
                {
                    Product_Name = viewModel.Name,
                    Product_Description = viewModel.Description,
                    Product_Price = viewModel.Price,
                };
                using (var context = new ProductRepository())
                {
                    context.insert(n);
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
        public ActionResult Update(int Id,[Bind(Include ="Name,Description,Price")]ProductViewModel viewModel)
        {
            if (ModelState.IsValid) 
            {
                Product n = new Product()
                {
                    Product_Name = viewModel.Name,
                    Product_Description = viewModel.Description,
                    Product_Price = viewModel.Price,
                };
                using (var context = new ProductRepository())
                {
                    context.update(Id,n);
                    return RedirectToAction("Index");
                }
            }
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            if (ModelState.IsValid) 
            {
                using (var context = new ProductRepository())
                {
                    var temp=context.whereById(Id);
                    context.delete(temp);
                    TempData["success"] = "Successfully Deleted";
                    return Redirect("Index");
                }
            }
            TempData["error"] = "Already Deleted Or Something Wrong";
            return Redirect(HttpContext.Request.UrlReferrer.ToString());
        }
    }
}
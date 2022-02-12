using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Repository;
using Core.Entity;

namespace WebApplicationPOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ListProduct()
        {
            IEnumerable<Product> products;
            using (var repo = new ProductRepository())
            {
                products = repo.getall();
            }
            return View(products);
        }

        public ActionResult FindProduct(int Id)
        {
            Product products;
            using (var repo = new ProductRepository())
            {
                products = repo.whereById(Id);
            }
            return View(products);
        }

        //public ActionResult AddToCart(int Id)
        //{
        //   if(Session.)
        //    return RedirectToAction("FindProduct", new { Id = Id });
        //}
    }
}
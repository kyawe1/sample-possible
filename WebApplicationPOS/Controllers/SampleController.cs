using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Core.Entity;
using System.Web;
using Application.Repository;

namespace WebApplicationPOS.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            List<Employee> employee;
            using(var repo=new EmployeeRepository())
            {
                employee = (List<Employee>)repo.getall();
            }
            return View(employee);
        }
    }
}
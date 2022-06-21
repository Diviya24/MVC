 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public static List<product> products = new List<product>()
            {
                new product{Id=1,Name="samgung",price=20000},
                new product{Id=2,Name="OnePluse",price=35000},
                new product{Id=3,Name="RealMe",price=17000},
                new product{Id=4,Name="Apple11",price=50000}
            };
        // GET: Home
        public ActionResult Index()
        {
           
            return View(products);
        }
        [HttpGet] 
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(product prod)
        {
            products.Add(prod);
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public ActionResult Update(int Id)
        {
            product prod = products.Where(x => x.Id==Id).FirstOrDefault();
            return View(prod);
        }
        [HttpPost]
        public ActionResult Update(product prod)
        {
            products.Remove(products.Where(x => x.Id == prod.Id).FirstOrDefault());
            products.Add(prod);
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            products.Remove( products.Where(x => x.Id == Id).FirstOrDefault());
            return RedirectToAction("Index", "Home");
        }
       
    }
}
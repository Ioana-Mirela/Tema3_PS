using MvcShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop.Controllers
{
    public class HomeController : Controller
    {
        private ProductDBContext db = new ProductDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "We are pleased to offer you fresh fruits and vegetables.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Message = "This is the list of all the products in our store.";

            return View(db.Products.ToList());
        }
    }
}
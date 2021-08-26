using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PavillionData.Models;
using PavillionData.Repository;

namespace PavillionMedical.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();
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
        public ActionResult Explore()
        {
            var list = context.Physicians.ToList();

            return View(list);
        }
    }
}
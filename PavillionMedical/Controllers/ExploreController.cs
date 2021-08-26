using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PavillionData.Models;
using PavillionData.Repository;

namespace PavillionMedical.Controllers
{
    public class ExploreController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();
        // GET: Explore
        public ActionResult Index()
        {
            var list = context.Physicians.ToList();

            return View(list);
        }
        public ActionResult ViewPhysician(int id)
        {
            var profile = context.Physicians.Find(id);

            return View(profile);
        }
        public ActionResult Search(string input)
        {
            var result = context.Physicians.Where(c => c.FirstName.Contains(input) || c.FirstName.ToLower().Contains(input) || c.FirstName.ToUpper().Contains(input)
            || c.LastName.ToLower().Contains(input) || c.LastName.ToUpper().Contains(input) || c.Specialisation.Contains(input) || c.Specialisation.ToUpper().Contains(input)
            || c.Specialisation.ToLower().Contains(input)).ToList();

            return View(result);
        }
    }
}
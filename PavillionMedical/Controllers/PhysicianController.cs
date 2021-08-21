using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using PavillionData.Models;
using PavillionData.Models.ViewModels;
using PavillionData.Repository;
using System.Data.Entity;


namespace PavillionMedical.Controllers
{
    public class PhysicianController : Controller
    {
        private readonly ApplicationDbContext Context = new ApplicationDbContext();

        // GET: Physician
        public ActionResult Index()
        {
            var UserId = User.Identity.GetUserId();
            var Profile = Context.Physicians.Where(c => c.UserId == UserId).FirstOrDefault();

            if (Profile == null)
            {
                return RedirectToAction("FirstView");
            }

            PhysicianPersonalProfile physicianPersonal = new PhysicianPersonalProfile()
            {             
                physician = Profile,
                ChatCodes = Profile.ChatCodes.OrderByDescending(c => c.CodeId).ToList()
            };

            return View(physicianPersonal);
        }

        public ActionResult GenerateCode(ChatCode chatCode)
        {
            Random random = new Random();

            var UserId = User.Identity.GetUserId();
            var Profile = Context.Physicians.Where(c => c.UserId == UserId).FirstOrDefault();

            chatCode = new ChatCode()
            {
                CodeContent = random.Next(00000, 99999),
                DateGenerated = DateTime.Now
                
              
            };

            regenerate:

            var ExistingCodes = Profile.ChatCodes.Where(c => c.CodeContent == chatCode.CodeContent).FirstOrDefault();

            if (ExistingCodes != null)
            {
                chatCode.CodeContent = random.Next(00000, 99999);
                goto regenerate;
            }

            Profile.ChatCodes.Add(chatCode);
            Context.ChatCodes.Add(chatCode);

            Context.SaveChanges();

            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult FirstView()
        {
            return View();
        }
        //Create Physician Profile
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string UserId, Physician Physician)
        {
            UserId = User.Identity.GetUserId();

            try
            {
                Physician = new Physician
                {
                    UserId = UserId,
                    FirstName = Physician.FirstName,
                    LastName = Physician.LastName,
                    Biography = Physician.Biography,

                };

            }
            catch (Exception)
            {

                return Content("placeholder");
            }

            Context.Physicians.Add(Physician);
            Context.SaveChanges();

            return RedirectToAction("Index");
        }
        //Edit Physician Profile
        [Authorize]
        public ActionResult Edit()
        {
           
            return View();

        }
        [HttpPost]
        public ActionResult Edit(string UserId, Physician Physician)
        {
            UserId = User.Identity.GetUserId();
            var physicianData = Context.Physicians.Where(c => c.UserId == UserId).FirstOrDefault();

            if (physicianData != null)
            {
                try
                {
                    physicianData.FirstName = Physician.FirstName;
                    physicianData.LastName = Physician.LastName;
                    physicianData.Biography = Physician.Biography;
                }
                catch (Exception)
                {

                    return Content("Place holder");
                }
                
            }

            Context.Entry(physicianData).Property(z => z.UserId).IsModified = false;

            Context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
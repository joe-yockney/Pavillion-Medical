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
        public ActionResult ViewPhysician(int id, ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.Error ? "This code has already been used or doesnt exist."
                : message == ManageMessageId.Success ? "Comment successfully posted."             
                : "";

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
        public ActionResult AddComment(int id, string input, int rating, int chatcode, string name)
        {
            PatientPin chatCode = context.ChatCodes.Where(c => c.CodeContent == chatcode).FirstOrDefault();

            Physician physician = context.Physicians.Find(id);

            if (chatCode != null)
            {
                if (chatCode.Status == 1 || chatCode.Status == 2)
                {
                    return RedirectToAction("ViewPhysician", new { id = id });
                }
            }
            

            if (physician.PatientPins.Contains(chatCode))
            {
                PatientComment patientComment = new PatientComment
                {
                    Content = input,
                    DateCommented = DateTime.Now,
                    Rating = rating,
                    Name = name,               
                };

                physician.PatientComments.Add(patientComment);

                chatCode.Status = 1;
            }
            else
            {
                ModelState.AddModelError("", "Sorry, that code is incorrect or has already been used");
                return RedirectToAction("ViewPhysician", new { Message = ManageMessageId.Error, id = id });
            }

            context.SaveChanges();


            return RedirectToAction("ViewPhysician", new { id = id });
        }
        public enum ManageMessageId
        {
            Error,
            Success
        }
    }

}
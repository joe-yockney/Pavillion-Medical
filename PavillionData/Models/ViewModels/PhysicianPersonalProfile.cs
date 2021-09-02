using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PavillionData.Repository;
using PavillionData.Models;
using System.Web;
using Microsoft.AspNet.Identity;

namespace PavillionData.Models.ViewModels
{
    public class PhysicianPersonalProfile
    {
        private readonly PavillionContext context = new PavillionContext();

        public Physician physician { get; set; }
        public IList<PatientComment> PatientComments { get; set; }
        public IList<PatientPin> ChatCodes { get; set; }
        public IList<PatientMessage> PatientMessages { get; set; }

        public int UnreadMessages()
        {
            string id = HttpContext.Current.User.Identity.GetUserId();
            int result = context.PatientMessages.Where(c => c.IsRead == false).Count();

            return result;
        }

    }

}

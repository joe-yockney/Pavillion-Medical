using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PavillionData.Models
{
    public class Physician
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string Practice { get; set; }
        public string Specialisation { get; set; }
        public string Biography { get; set; }
        public string Qualifications { get; set; }
        public int Recommendations { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<PatientComment> PatientComments { get; set; }
        public virtual ICollection<PatientPin> PatientPins { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<PatientMessage> PatientMessages { get; set; }

        [NotMapped]
        public HttpPostedFileBase UserPicture { get; set; }
    }
}

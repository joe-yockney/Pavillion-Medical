using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavillionData.Models
{
    public class Physician
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public int Recommendations { get; set; }
        public virtual ICollection<PatientComment> PatientComments { get; set; }
        public virtual ICollection<ChatCode> ChatCodes { get; set; }
    }
}

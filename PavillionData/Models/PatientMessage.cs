using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PavillionData.Models;
using PavillionData.Repository;

namespace PavillionData.Models
{
    public class PatientMessage
    {
        [Key]
        public int MessageId { get; set; }
        public string MessageContent { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public DateTime Datesent { get; set; }
        public bool IsRead { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavillionData.Models
{
    public class PatientComment
    {
        [Key]
        public int CommentId { get; set; }
        public DateTime DateCommented { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }
}

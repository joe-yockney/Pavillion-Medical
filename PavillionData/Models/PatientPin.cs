using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavillionData.Models
{
    public class PatientPin
    {
        [Key]
        public int CodeId { get; set; }
        public int CodeContent { get; set; }
        public DateTime DateGenerated { get; set; }
        public int Status { get; set; }
    }
}

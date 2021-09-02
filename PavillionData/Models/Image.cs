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
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public string Filename { get; set; }
        public string ImageName { get; set; }
        public string ImageDesc { get; set; }
    }
}

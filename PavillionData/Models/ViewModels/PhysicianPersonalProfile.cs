using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PavillionData.Repository;
using PavillionData.Models;

namespace PavillionData.Models.ViewModels
{
    public class PhysicianPersonalProfile
    {
        public Physician physician { get; set; }
        public IList<PatientComment> PatientComments { get; set; }
        public IList<PatientPin> ChatCodes { get; set; }

    }

}

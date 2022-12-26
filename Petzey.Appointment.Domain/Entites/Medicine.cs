using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.Entites
{
    public class Medicine
    {
        public int Medicined { get; set; }
        public string MedicineName { get; set; }
        public int Days { get; set; }
        public string AdditionalComments { get; set; }
        public InTake inTake { get; set; }
        public TimeOfDay timeOfDay { get; set; }
    }
}

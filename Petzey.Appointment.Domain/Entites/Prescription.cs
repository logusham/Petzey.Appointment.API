using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.Entites
{
    public class Prescription
    {
        public int Id { get; set; }
        public List<Medicine> medicine { get; set; }
    }
}

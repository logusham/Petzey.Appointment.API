using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.Entites
{
    public class Vital
    {
        public int Id { get; set; }
        public float Ecg { get; set; }
        public float Temperature { get; set; }
        public float Respiration { get; set; }
    }
}

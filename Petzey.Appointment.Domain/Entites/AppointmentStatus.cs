using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.Entites
{
    public class AppointmentStatus
    {
        public int AppointmentStatusId { get; set; }
        public Status Status { get; set; }
    }
}


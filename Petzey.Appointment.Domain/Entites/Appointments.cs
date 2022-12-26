using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Petzey.Appointment.Domain.Entites
{
    public class Appointments
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string Issue { get; set; }
        public string Comment { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
        public Vet vet { get; set; }
        public Pet pet { get; set; }
        public AppointmentStatus appointmentStatus { get; set; }
        public Prescription prescription { get; set; }
        public Vital vital { get; set; }
        public List<Test> tests { get; set; }
    }
}

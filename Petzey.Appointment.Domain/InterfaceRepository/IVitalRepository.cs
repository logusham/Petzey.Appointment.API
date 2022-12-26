using Petzey.Appointment.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.InterfaceRespository
{
    public interface IVitalRepository
    {
        public Vital AddVitalByAppointmentId(Vital vital, int appointmentId);
        public bool UpdateVital(Vital vital);
        public bool DeleteVital(int vitalId);
        public Vital GetVitalById(int vitalId);
        public Vital GetVitalByAppointmentId(int appointmentId);
    }
}

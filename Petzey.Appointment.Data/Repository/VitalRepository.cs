using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.Domain.InterfaceRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Data.Respository
{
    public class VitalRepository : IVitalRepository
    {
        public Vital AddVitalByAppointmentId(Vital vital, int appointmentId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVital(int vitalId)
        {
            throw new NotImplementedException();
        }

        public Vital GetVitalByAppointmentId(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public Vital GetVitalById(int vitalId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateVital(Vital vital)
        {
            throw new NotImplementedException();
        }
    }
}

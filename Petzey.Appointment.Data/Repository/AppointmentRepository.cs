using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.Domain.InterfaceRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Data.Respository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public Appointments CloseAppointment(Appointments appointment)
        {
            throw new NotImplementedException();
        }

        public List<Appointments> GetAllAppointmentByDate(int vetId, DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public List<Appointments> GetAllAppointmentFillterWithStatus(int doctorId, AppointmentStatus status, DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public List<Appointments> GetAllAppointments()
        {
            throw new NotImplementedException();
        }

        public List<Appointments> GetAllAppointmentsByPetParentId(int petParentId, DateTime tromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public List<Appointments> GetAllAppointmentsByPetParentIdandStatus(int petParentId, AppointmentStatus status)
        {
            throw new NotImplementedException();
        }

        public List<Appointments> GetAllAppointmentsByVetId(int vetId, DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public Appointments GetAppointment(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public List<int> GetIdsAssociatedWithAppointment(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public bool RejectAppointment(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public int TotalAppointmentCount(int doctorId)
        {
            throw new NotImplementedException();
        }

        public int TotalAppointmentCountBasedOnStatus(int doctorId, AppointmentStatus status)
        {
            throw new NotImplementedException();
        }
    }
}

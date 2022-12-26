using Petzey.Appointment.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.InterfaceRespository
{
    public interface IAppointmentRepository
    {
        public Appointments GetAppointment(int appointmentId);
        public List<Appointments> GetAllAppointments();
        public Appointments CloseAppointment(Appointments appointment);
        public List<int> GetIdsAssociatedWithAppointment(int appointmentId);
        public List<Appointments> GetAllAppointmentsByVetId(int vetId, DateTime fromDate, DateTime toDate);
        public List<Appointments> GetAllAppointmentsByPetParentId(int petParentId, DateTime tromDate, DateTime toDate);
        public List<Appointments> GetAllAppointmentFillterWithStatus(int doctorId, AppointmentStatus status, DateTime fromDate, DateTime toDate);
        public bool RejectAppointment(int appointmentId);
        public int TotalAppointmentCount(int doctorId);
        public int TotalAppointmentCountBasedOnStatus(int doctorId, AppointmentStatus status);
        public List<Appointments> GetAllAppointmentByDate(int vetId, DateTime fromDate, DateTime toDate);
        public List<Appointments> GetAllAppointmentsByPetParentIdandStatus(int petParentId, AppointmentStatus status);
    }
}

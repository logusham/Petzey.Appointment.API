using Petzey.Appointment.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.InterfaceRespository
{
    public interface ITestRepository
    {
        public Test AddTestByAppointmentId(Test testToSave, int appointmentId);
        public bool UpdateTest(Test testToUpdate);
        public bool DeleteTest(int testId);
        public Test GetTestById(int testId);
        public List<Test> GetTestByAppointmentId(int appointmentId);
    }
}

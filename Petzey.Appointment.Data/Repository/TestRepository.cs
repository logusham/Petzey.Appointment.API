using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.Domain.InterfaceRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Data.Respository
{
    public class TestRepository : ITestRepository
    {
        public Test AddTestByAppointmentId(Test testToSave, int appointmentId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTest(int testId)
        {
            throw new NotImplementedException();
        }

        public List<Test> GetTestByAppointmentId(int appointmentId)
        {
            throw new NotImplementedException();
        }

        public Test GetTestById(int testId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTest(Test testToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

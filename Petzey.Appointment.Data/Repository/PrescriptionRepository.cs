using Petzey.Appointment.Domain.Entites;
using Petzey.Appointment.Domain.InterfaceRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Data.Respository
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        public Medicine AddMedicine(Medicine medicine, int appointmentId)
        {
            throw new NotImplementedException();
        }

        public Prescription AddPrescription(Prescription prescription, int appointmentId)
        {
            throw new NotImplementedException();
        }

        public Prescription EditPrescription(Prescription prescription, int appointmentId)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAllMedicinesByPrescriptionId(int prescriptionId)
        {
            throw new NotImplementedException();
        }

        public Medicine GetMedicine(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

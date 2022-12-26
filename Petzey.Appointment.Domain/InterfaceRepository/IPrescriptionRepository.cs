using Petzey.Appointment.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.Appointment.Domain.InterfaceRespository
{
    public interface IPrescriptionRepository
    {
        public Prescription AddPrescription(Prescription prescription, int appointmentId);
        public Medicine AddMedicine(Medicine medicine, int appointmentId);
        public Prescription EditPrescription(Prescription prescription, int appointmentId);
        public Medicine GetMedicine(int Id);
        public List<Medicine> GetAllMedicinesByPrescriptionId(int prescriptionId);
    }
}

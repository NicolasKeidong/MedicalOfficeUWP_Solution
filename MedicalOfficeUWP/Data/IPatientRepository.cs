using MedicalOfficeUWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOfficeUWP.Data
{
    public interface IPatientRepository
    {
        Task<List<Patient>> GetPatients();
        Task<Patient> GetPatientById(int ID);
        Task<List<Patient>> GetPatientsByDoctor(int ID);

        Task AddPatient(Patient patientToAdd);
        Task UpdatePatient(Patient patientToUpdate);
        Task DeletePatient(Patient patientToDelete);
    }
}

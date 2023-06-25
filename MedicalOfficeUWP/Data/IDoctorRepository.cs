using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalOfficeUWP.Models;

namespace MedicalOfficeUWP.Data
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> GetDoctors();
        Task<Doctor> GetDoctor(int ID);

        Task AddDoctor(Doctor doctorToAdd);
        Task UpdateDoctor(Doctor doctorToUpdate);
        Task DeleteDoctor(Doctor doctorToDelete);

    }
}

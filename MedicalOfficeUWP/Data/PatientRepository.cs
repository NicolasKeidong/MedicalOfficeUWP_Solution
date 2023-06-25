using MedicalOfficeUWP.Models;
using MedicalOfficeUWP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOfficeUWP.Data
{
    internal class PatientRepository : IPatientRepository
    {
        private readonly HttpClient client = new HttpClient();

        public PatientRepository() 
        {
            client.BaseAddress = Jeeves.DBUri;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Patient> GetPatientById(int ID)
        {
            HttpResponseMessage response = await client.GetAsync($"api/patients/history/{ID}");
            if (response.IsSuccessStatusCode)
            {
                Patient patient = await response.Content.ReadAsAsync<Patient>();
                return patient;
            }
            else
            {
                throw new Exception("Could not access that Patient.");
            }
        }

        public async Task<List<Patient>> GetPatients()
        {
            HttpResponseMessage response = await client.GetAsync("api/patients/history");
            if (response.IsSuccessStatusCode)
            {
                List<Patient> patients = await response.Content.ReadAsAsync<List<Patient>>();
                return patients;
            }
            else
            {
                throw new Exception("Could not access the list of Patients.");
            }
        }

        public async Task<List<Patient>> GetPatientsByDoctor(int DoctorID)
        {
            HttpResponseMessage response = await client.GetAsync($"api/patients/byDoctorHistory/{DoctorID}");
            if (response.IsSuccessStatusCode)
            {
                List<Patient> patients = await response.Content.ReadAsAsync<List<Patient>>();
                return patients;
            }
            else
            {
                throw new Exception("Could not access the list of Patients by Doctor.");
            }
        }

        public async Task AddPatient(Patient patientToAdd)
        {
            var response = await client.PostAsJsonAsync("/api/patients", patientToAdd);
            if (!response.IsSuccessStatusCode)
            {
                var ex = Jeeves.CreateApiException(response);
                throw ex;
            }
        }

        public async Task DeletePatient(Patient patientToDelete)
        {
            var response = await client.DeleteAsync($"/api/patients/{patientToDelete.ID}");
            if (!response.IsSuccessStatusCode)
            {
                var ex = Jeeves.CreateApiException(response);
                throw ex;
            }
        }

        public async Task UpdatePatient(Patient patientToUpdate)
        {
            var response = await client.PutAsJsonAsync($"/api/patients/{patientToUpdate.ID}", patientToUpdate);
            if (!response.IsSuccessStatusCode)
            {
                var ex = Jeeves.CreateApiException(response);
                throw ex;
            }
        }
    }
}

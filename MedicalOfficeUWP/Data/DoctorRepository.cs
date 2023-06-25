﻿using MedicalOfficeUWP.Models;
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
    public class DoctorRepository : IDoctorRepository
    {
        private readonly HttpClient client = new HttpClient();

        public DoctorRepository() 
        {
            client.BaseAddress = Jeeves.DBUri;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Doctor> GetDoctor(int ID)
        {
            HttpResponseMessage response = await client.GetAsync($"api/doctors/{ID}");
            if (response.IsSuccessStatusCode)
            {
                Doctor doctor = await response.Content.ReadAsAsync<Doctor>();
                return doctor;
            }
            else
            {
                throw new Exception("Could not access that Doctor.");
            }
        }

        public async Task<List<Doctor>> GetDoctors()
        {
            HttpResponseMessage response = await client.GetAsync("api/doctors");
            if (response.IsSuccessStatusCode)
            {
                List<Doctor> doctors = await response.Content.ReadAsAsync<List<Doctor>>();
                return doctors;
            }
            else
            {
                throw new Exception("Could not access the list of Doctors.");
            }
        }

        public async Task AddDoctor(Doctor doctorToAdd)
        {
            var response = await client.PostAsJsonAsync("/api/doctors", doctorToAdd);
            if(!response.IsSuccessStatusCode)
            {
                var ex = Jeeves.CreateApiException(response);
                throw ex;
            }
        }

        public async Task UpdateDoctor(Doctor doctorToUpdate)
        {
            var response = await client.PutAsJsonAsync($"/api/doctors/{doctorToUpdate.ID}", doctorToUpdate);
            if(!response.IsSuccessStatusCode)
            {
                var ex = Jeeves.CreateApiException(response);
                throw ex;
            }
        }

        public async Task DeleteDoctor(Doctor doctorToDelete)
        {
            var response = await client.DeleteAsync($"/api/doctors/{doctorToDelete.ID}");
            if(!response.IsSuccessStatusCode) 
            {
                var ex = Jeeves.CreateApiException(response);
                throw ex;
            }
        }
    }
}

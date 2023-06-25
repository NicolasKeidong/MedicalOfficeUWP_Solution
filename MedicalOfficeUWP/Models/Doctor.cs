using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;

namespace MedicalOfficeUWP.Models
{
    public class Doctor
    {
        public int ID { get; set; }

        public string FullName
        {
            get
            {
                return "Dr. " + FirstName + (string.IsNullOrEmpty(MiddleName) ? " " :
                    (" " + (char?)MiddleName[0] + ". ").ToUpper())
                    + LastName;
            }
        }

        public string FormalName
        {
            get
            {
                return LastName + ", " + FirstName
                    + (string.IsNullOrEmpty(MiddleName) ? "" :
                    (" " + (char?)MiddleName[0] + ". ").ToUpper());
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public byte[] RowVersion { get; set; }

        public ICollection<Patient> Patients { get; set; }
    }
}

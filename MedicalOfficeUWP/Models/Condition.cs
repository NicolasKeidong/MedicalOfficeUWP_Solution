using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalOfficeUWP.Models
{
    public class Condition
    {
        int ID { get; set; }

        public string ConditionName { get; set; }

        public ICollection<Patient> Patients { get; set; }
    }
}

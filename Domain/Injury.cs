using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patients
{
    public class Injury
    {
        public int id {  get; set; }
        public string type { get; set; }
        public string treatement { get; set; }
        public int patientid { get; set; }

       public Injury(string type, string treatement)
        {
            this.type = type;
            this.treatement= treatement;
        }
        
    }
}

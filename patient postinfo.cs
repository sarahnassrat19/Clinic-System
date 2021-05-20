using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_System
{
    public class patient_postinfo:patient
    {
        private string[] Medicines;
        private string date_of_reveal;
        private string date_of_recheck;
        private bool recheck;
        public string[] med
        {
            get;
            set;
        }
        public string date1
        {
            get;
            set;
        }
        public string date2
        {
            get;
            set;
        }
        public bool recheck_date
        {
            get;
            set;
        }
        public patient_postinfo( string[] m, string d1, string d2,bool re, int id, string name, params string[] chronic) : base(id, name, chronic)
        {
            med = m;
            date1 = d1;
            date2 = d2;
            recheck_date = re;
        }
    }
}

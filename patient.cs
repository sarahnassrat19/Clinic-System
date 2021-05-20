using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_System
{
    public class patient
    {
        private int id;
        private string name;
        private string[] chronic_diseases;

        public int p_id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string p_name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string[] p_chronic
        {
            get;
            set;
        }
        public patient(int id, string name)
        {
            p_id = id;
            p_name = name;
        }
        public patient(int id, string name, params string[] chronic)
        {
            p_id = id;
            p_name = name;
            p_chronic = chronic;
        }

    }
}

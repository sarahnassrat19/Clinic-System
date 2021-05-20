using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_System
{
    public partial class report1 : Form
    {
        patient_postinfo pp;
        TextBox p_report;
        public report1()
        {
            InitializeComponent();

            Width = 1000;
            Height = 1000;

            p_report = new TextBox();
            p_report.Multiline = true;
            p_report.Location = new Point(Width / 6, 250);
            p_report.Size = new Size(Width - 300, 220);
            p_report.Enabled = false;

            string rechecked_date;
            if (pp.recheck_date == true)
            {
                rechecked_date = "true";
            }
            else
            {
                rechecked_date = "false";
            }
            string med = string.Join("\n", pp.med);

            string str = med + Environment.NewLine + pp.date1 + Environment.NewLine + pp.date2 + Environment.NewLine + rechecked_date;
            p_report.Text = str;


            Controls.Add(p_report);

        }
    }
}

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
    public partial class history1 : Form
    {
        patient_postinfo pp;
        TextBox []history;
        public history1()
        {
            InitializeComponent();
            Width = 1000;
            Height = 1000;

            history = new TextBox[10];
            int h = 50;
            int i = 0;
            while (i < 10)
            {
                history[i] = new TextBox();
                history[i].Multiline = true;
                history[i].Location = new Point(Width / 6, h);
                history[i].Size = new Size(Width-300, 250);
                history[i].Enabled = false;

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
                history[i].Text = str;
                h += 270;
                i++;
            }
            Controls.AddRange(history);
        }
    }
}

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
    public partial class postinfo : Form
    {
        patient_postinfo pp;
        TextBox med;
        TextBox d1;
        TextBox d2;
        Label lb1;
        Label lb2;
        Label lb3;
        Label lb4;
        Button submit;
        CheckBox recheck;
        public static void make_record(object sender, EventArgs a)
        {
            MessageBox.Show("patient record has done", "done", MessageBoxButtons.OK);
        }
        public postinfo()
        {
            InitializeComponent();
            Width = 1000;
            Height = 1000;

            lb1 = new Label();
            lb2 = new Label();
            lb3 = new Label();
            lb4 = new Label();
            med = new TextBox();
            d1 = new TextBox();
            d2 = new TextBox();
            submit = new Button();
            recheck = new CheckBox();

            lb1.Location = new Point(Width / 6, Height / 4);
            lb2.Location = new Point(Width / 6, Height / 4 + 210);
            lb3.Location = new Point(Width / 6, Height / 4 + 270);
            lb4.Location = new Point(Width / 6, Height / 4 + 330);


            med.Location = new Point(Width / 2, Height / 4);
            d1.Location = new Point(Width / 2, Height / 4 + 210);
            d2.Location = new Point(Width / 2, Height / 4 + 270);
            recheck.Location = new Point(Width / 2, Height / 4 + 330);

            submit.Location = new Point(Width / 3 + 50, Height - 200);

            lb1.Size = new Size(200, 50);
            lb2.Size = new Size(200, 50);
            lb3.Size = new Size(200, 50);
            lb4.Size = new Size(200, 50);

            lb1.BackColor = System.Drawing.Color.Transparent;
            lb2.BackColor = System.Drawing.Color.Transparent;
            lb3.BackColor = System.Drawing.Color.Transparent;
            lb4.BackColor = System.Drawing.Color.Transparent;
            lb1.ForeColor = System.Drawing.Color.White;
            lb2.ForeColor = System.Drawing.Color.White;
            lb3.ForeColor = System.Drawing.Color.White;
            lb4.ForeColor = System.Drawing.Color.White;

            med.Size = new Size(250, 200);
            d1.Size = new Size(250, 50);
            d2.Size = new Size(250, 50);

            submit.Size = new Size(200, 50);

            Font fo = new Font("arial", 18, FontStyle.Regular);
            lb1.Text = "Medicines:";
            lb2.Text = "date_of_reveal:";
            lb3.Text = "date_of_recheck:";
            lb4.Text = "recheck:";
            submit.Text = "make a Record";
            submit.Font = fo;
            lb1.Font = fo;
            lb2.Font = fo;
            lb3.Font = fo;
            lb3.Font = fo;

            med.Multiline = true;

            string[] med_arr = med.Text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //pp = new patient_postinfo(med_arr, d1.Text, d2.Text,recheck.Checked, pp.p_id, pp.p_name, pp.p_chronic);

            submit.Click += make_record;

            Controls.Add(lb1);
            Controls.Add(lb2);
            Controls.Add(lb3);
            Controls.Add(med);
            Controls.Add(d1);
            Controls.Add(d2);
            Controls.Add(submit);

        }
    }
}

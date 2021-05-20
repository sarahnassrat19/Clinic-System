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
    
    public partial class report : Form
    {
        patient_postinfo pp;
        Label lb1;
        Label lb2;
        TextBox id;
        TextBox name;
        Button submit;
        bool is_patientExist;

        public void make_rep(object sender, EventArgs a)
        {

            if (is_patientExist == true)
            {
                report1 re = new report1();
                re.ShowDialog();
            }
            else
            {
                MessageBox.Show("this patient is not exist !", "Sorry");
            }
        }
        public report()
        {
            InitializeComponent();

            Width = 1000;
            Height = 1000;

            lb1 = new Label();
            lb2 = new Label();
            id = new TextBox();
            name = new TextBox();
            submit = new Button();


            lb1.Location = new Point(Width / 6, Height / 4);
            lb2.Location = new Point(Width / 6, Height / 4 + 60);

            id.Location = new Point(Width / 2, Height / 4);
            name.Location = new Point(Width / 2, Height / 4 + 60);

            submit.Location = new Point(Width / 3 + 40, Height - 200);

            lb1.Size = new Size(200, 50);
            lb2.Size = new Size(200, 50);

            lb1.BackColor = System.Drawing.Color.Transparent;
            lb2.BackColor = System.Drawing.Color.Transparent;

            lb1.ForeColor = System.Drawing.Color.White;
            lb2.ForeColor = System.Drawing.Color.White;

            id.Size = new Size(250, 70);
            name.Size = new Size(250, 70);

            submit.Size = new Size(220, 50);

            Font fo = new Font("arial", 18, FontStyle.Regular);
            lb1.Text = "patient ID:";
            lb2.Text = "patient Name:";
            submit.Text = "make a report";

            submit.Font = fo;
            lb1.Font = fo;
            lb2.Font = fo;

            string name_str = name.Text;
            bool a = true;
            foreach (int i in name_str)
            {
                if (i >= '0' && i <= '9')
                {
                    a = false;
                }
            }

            int id_num;
            bool b = int.TryParse(id.Text, out id_num);
            if (a & b)
            {
                if (id_num == pp.p_id && name.Text == pp.p_name)
                {
                    is_patientExist = true;
                }
                else
                {
                    is_patientExist = false;
                }
            }
            else
            {
                MessageBox.Show("invalid ID or name !");
            }

            submit.Click += make_rep;

            Controls.Add(id);
            Controls.Add(name);
            Controls.Add(lb1);
            Controls.Add(lb2);
            Controls.Add(submit);

        }
    }
}

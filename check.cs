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
    public partial class check : Form
    {
        patient p;
        Label lb1;
        Label lb2;
        Label lb3;
        TextBox id;
        TextBox name;
        TextBox chronic;
        Button submit;
        public void sign_up(object sender, EventArgs a)
        {

            string name_str = name.Text;
            bool aa = true;
            foreach (int i in name_str)
            {
                if (i >= '0' && i <= '9')
                {
                    aa = false;
                }
            }

            string[] chronic_arr = chronic.Text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int id_num;
            bool b = int.TryParse(id.Text, out id_num);

            if (aa & b)
            {
                p = new patient(id_num, name.Text, chronic_arr);
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("invalid ID or name !");
            }
        }
        public check()
        {
            InitializeComponent();
            Width = 1000;
            Height = 1000;

            lb1 = new Label();
            lb2 = new Label();
            lb3 = new Label();
            id = new TextBox();
            name = new TextBox();
            chronic = new TextBox();
            submit = new Button();
            
            //___________________________________design_______________________________________//
            lb1.Location = new Point(Width / 6, Height / 4);
            lb2.Location = new Point(Width / 6, Height / 4+60);
            lb3.Location = new Point(Width / 6, Height / 4+120);

            id.Location = new Point(Width / 2, Height / 4);
            name.Location = new Point(Width / 2, Height / 4 + 60);
            chronic.Location = new Point(Width / 2 , Height / 4 + 120);

            submit.Location = new Point(Width/3+50, Height - 200);

            lb1.Size = new Size(200, 50);
            lb2.Size = new Size(200, 50);
            lb3.Size = new Size(200, 50);
            lb1.BackColor = System.Drawing.Color.Transparent;
            lb2.BackColor = System.Drawing.Color.Transparent;
            lb3.BackColor = System.Drawing.Color.Transparent;
            lb1.ForeColor = System.Drawing.Color.White;
            lb2.ForeColor = System.Drawing.Color.White;
            lb3.ForeColor = System.Drawing.Color.White;


            id.Size = new Size(250, 50);
            name.Size = new Size(250, 50);
            chronic.Size = new Size(250,200);

            submit.Size = new Size(200, 50);

            Font fo = new Font("arial", 18, FontStyle.Regular);
            lb1.Text = "patient ID:";
            lb2.Text = "patient Name:";
            lb3.Text = "chronic diseases:";
            submit.Text = "Sign up";
            submit.Font = fo;
            lb1.Font = fo;
            lb2.Font = fo;
            lb3.Font = fo;

            chronic.Multiline = true;
            //______________________________________end design____________________________________//

            



            //__________________________________button handling & controls__________________________//
            submit.Click += sign_up;

            Controls.Add(id);
            Controls.Add(name);
            Controls.Add(chronic);
            Controls.Add(lb1);
            Controls.Add(lb2);
            Controls.Add(lb3);
            Controls.Add(submit);

        }
        
    }
}

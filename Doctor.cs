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
    public partial class Doctor : Form
    {
        Label lb = new Label();
        Button btn1 = new Button();
        Button btn2 = new Button();
        void postinfo(object sender ,EventArgs a)
        {
            postinfo po = new Clinic_System.postinfo();
            po.ShowDialog();
        }
        void report(object sender ,EventArgs a)
        {
            report re = new Clinic_System.report();
            re.ShowDialog();
        }
        public Doctor()
        {
            InitializeComponent();
            Height = 1000;
            Width = 1000;

            lb.Location = new Point(Width / 3, Height - (Height - 80));
            lb.Size = new Size(330, 70);
            lb.Text = "Doctor  Form";
            Font f = new Font("arial", 36, FontStyle.Bold);
            lb.Font = f;
            lb.BackColor = System.Drawing.Color.Transparent;
            lb.ForeColor = System.Drawing.Color.White;


            Font fo = new Font("arial", 18, FontStyle.Regular);

            btn1.Location = new Point((Width / 3) + 30, Height - (Height - 350));
            btn1.Size = new Size(250, 50);
            btn1.Text = "Post information";
            btn1.Font = fo;

            btn2.Location = new Point((Width / 3) + 55, Height - (Height - 430));
            btn2.Size = new Size(200, 50);
            btn2.Text = "Report";
            btn2.Font = fo;

            btn1.Click += postinfo;
            btn2.Click += report;


            Controls.Add(lb);
            Controls.Add(btn1);
            Controls.Add(btn2);
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }
    }
}

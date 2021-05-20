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
    public partial class Reciptionist_Form : Form
    {
        Label lb = new Label();
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        void check(object sender,EventArgs a)
        {
            check ch = new Clinic_System.check();
            ch.ShowDialog();
        }
        void recheck(object sender ,EventArgs a)
        {
            recheck rech = new Clinic_System.recheck();
            rech.ShowDialog();
        }
        void history(object sender,EventArgs a)
        {
            history his = new Clinic_System.history();
            his.ShowDialog();
        }
        public Reciptionist_Form()
        {
            InitializeComponent();
            Height = 1000;
            Width = 1000;

            lb.Location = new Point(Width / 4, Height - (Height - 80));
            lb.Size = new Size(450, 100);
            lb.Text = "Receptionist Form";
            Font f = new Font("arial", 36, FontStyle.Bold);
            lb.Font = f;
            lb.BackColor = System.Drawing.Color.Transparent;

            Font fo = new Font("arial", 18, FontStyle.Regular);
            btn1.Location = new Point((Width / 3)+15, Height - (Height - 350));
            btn1.Size = new Size(250, 50);
            btn1.Text = "make a check up";
            btn1.Font = fo;


            btn2.Location = new Point((Width / 3)+40, Height - (Height - 430));
            btn2.Size = new Size(200, 50);
            btn2.Text = "recheck";
            btn2.Font = fo;

            btn3.Location = new Point((Width / 3)+40, Height - (Height - 510));
            btn3.Size = new Size(200, 50);
            btn3.Text = "patient history";
            btn3.Font = fo;

            btn1.Click += check;
            btn2.Click += recheck;
            btn3.Click += history;


            Controls.Add(lb);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            
        }

        private void Reciptionist_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

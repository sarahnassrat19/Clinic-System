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
    public partial class Form1 : Form
    {
        Label lb = new Label();
        Label lb1 = new Label();
        Label lb2 = new Label();
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Button btn = new Button();
        void check(object sender, EventArgs a)
        {
            if (txt1.Text == "doctor" && txt2.Text == "1234")
            {
                Doctor d = new Doctor();
                d.ShowDialog();
            }
            else if (txt1.Text == "receptionist" && txt2.Text == "123")
            {
                Reciptionist_Form rf = new Reciptionist_Form();
                rf.ShowDialog();
            }
            else
            {
                MessageBox.Show("! incorrect username or password","Error",
                MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        public Form1()
        {
            InitializeComponent();
            Height = 1000;
            Width = 1000;

            lb.Location = new Point(Width/3, Height-(Height-80));
            lb.Size = new Size(350, 70);
            lb.Text = "Clinic System";
            Font f = new Font("arial", 36, FontStyle.Bold);
            lb.Font = f;
            lb.BackColor = System.Drawing.Color.Transparent;

            Font fo = new Font("arial", 18, FontStyle.Regular);
            lb1.Location = new Point(Width / 3, Height - (Height - 350));
            lb1.Size = new Size(122, 30);
            lb1.Text = "Username";
            lb1.Font = fo;
            lb1.BackColor = System.Drawing.Color.Transparent;

            lb2.Location = new Point(Width / 3, Height - (Height - 430));
            lb2.Size = new Size(120, 30);
            lb2.Text = "Password";
            lb2.Font = fo;
            lb2.BackColor = System.Drawing.Color.Transparent;

            txt1.Location = new Point(Width / 3+150, Height - (Height - 350)+2);
            txt2.Location = new Point(Width / 3+150, Height - (Height - 430)+2);

            txt1.Size = new Size(250, 50);
            txt2.Size = new Size(250, 50);
            
            txt2.PasswordChar = '*';

            btn.Location = new Point(Width / 3 + 150, Height - (Height - 600));
            btn.Size = new Size(100, 40);
            btn.Text = "Login";
            btn.Font = fo;
            
            
            btn.Click += check;
            


            Controls.Add(lb);
            Controls.Add(lb1);
            Controls.Add(lb2);
            Controls.Add(txt1);
            Controls.Add(txt2);
            Controls.Add(btn);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

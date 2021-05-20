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
    public partial class Error : Form
    {
        Label lb = new Label();
        public Error()
        {
            InitializeComponent();
            Height = 200;
            Width = 350;

            Font f = new Font("arial", 14, FontStyle.Bold);
            lb.Location = new Point(10, 60);
            lb.Size = new Size(400, 100);
            lb.Text = "! incorrect username or password";
            lb.Font = f;

            Controls.Add(lb);
        }
    }
}

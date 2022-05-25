using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class SplashScreen : Form
    {
        private System.Windows.Forms.Timer closeTimer = new System.Windows.Forms.Timer();

        public SplashScreen()
        {
            InitializeComponent();
            closeTimer.Interval = 5000; //5 seconds
            closeTimer.Tick += new EventHandler(closeTimer_Tick);
            closeTimer.Start();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

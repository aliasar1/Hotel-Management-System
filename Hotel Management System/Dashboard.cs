using Hotel_Management_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Dashboard : Form
    {
        HotelsScreen hs = new HotelsScreen();
        RoomsScreen rs = new RoomsScreen();
        BookingsScreen resScreen = new BookingsScreen();
        CheckoutScreen cs = new CheckoutScreen();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            hs.Hide();
            resScreen.Hide();
            cs.Hide();
            rs.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            rs.Hide();
            resScreen.Hide();
            cs.Hide();
            hs.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            rs.Hide();
            hs.Hide();
            cs.Hide();
            resScreen.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            rs.Hide();
            hs.Hide();
            resScreen.Hide();
            cs.Show();
        }
    }
}

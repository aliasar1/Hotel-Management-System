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
        GuestsScreen gs = new GuestsScreen();
        EmployeesScreen es = new EmployeesScreen();
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
            gs.Hide();
            es.Hide();
            rs.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            rs.Hide();
            resScreen.Hide();
            cs.Hide();
            es.Hide();
            gs.Hide();
            hs.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            rs.Hide();
            hs.Hide();
            gs.Hide();
            cs.Hide();
            resScreen.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            rs.Hide();
            hs.Hide();
            es.Hide();
            gs.Hide();
            resScreen.Hide();
            cs.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            rs.Hide();
            hs.Hide();
            es.Hide();
            gs.Hide();
            cs.Hide();
            resScreen.Hide();
            Login l = new Login();
            l.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            rs.Hide();
            hs.Hide();
            es.Hide();
            gs.Hide();
            resScreen.Hide();
            gs.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            rs.Hide();
            hs.Hide();
            gs.Hide();
            resScreen.Hide();
            gs.Hide();
            es.Show();
        }
    }
}

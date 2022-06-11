using Hotel_Management_System.Controllers;
using Hotel_Management_System.Screens;
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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loadForm(Object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loadForm(new RoomsScreen());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadForm(new HotelsScreen());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            loadForm(new BookingsScreen());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            loadForm(new CheckoutScreen());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            loadForm(new GuestsScreen());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadForm(new EmployeesScreen());
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            loadForm(new ServicesScreen());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadForm(new HotelIntroScreen());
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }
    }
}

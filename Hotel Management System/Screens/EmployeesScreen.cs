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

namespace Hotel_Management_System.Controllers
{
    public partial class EmployeesScreen : Form
    {
        public EmployeesScreen()
        {
            InitializeComponent();
            searchButton.Enabled = false;
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            CreateEmployeeAccountScreen createEmployee = new CreateEmployeeAccountScreen();
            createEmployee.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            searchButton.Enabled = true;
            employeeIdField.ReadOnly = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            employeeIdField.ReadOnly = true;
            addButton.Enabled = true;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            searchButton.Enabled = false;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DepartmentsScreen dep = new DepartmentsScreen();
            dep.Show();
        }
    }
}

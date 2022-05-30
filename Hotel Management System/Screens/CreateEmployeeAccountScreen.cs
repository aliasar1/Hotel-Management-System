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
    public partial class CreateEmployeeAccountScreen : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;

        public CreateEmployeeAccountScreen()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
            query = "DELETE FROM Hotels.Employees WHERE EmployeeId = " + EmployeesScreen.maxId;
            dc.setData(query, "Failed to insert as this employee must create account to register.");
            this.Hide();
            EmployeesScreen es = new EmployeesScreen();
            es.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO Authentication.Login (EmployeeId, username, password) VALUES (" + EmployeesScreen.maxId + ", '" + usernameTextField.Text + "', '" + passwordTextField.Text + "')";
            dc.setData(query, "Account created successfully.");
            this.Hide();
        }
    }
}

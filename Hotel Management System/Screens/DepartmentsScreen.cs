using Hotel_Management_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Screens
{
    public partial class DepartmentsScreen : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;

        private String name;
        private String description;
        private int salary;

        public DepartmentsScreen()
        {
            InitializeComponent();
            depIdField.ReadOnly = false;
        }

        private void GuestId_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            if (depIdField.Text == "")
            {
                MessageBox.Show("Please enter id to search record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool temp = false;
                SqlConnection con = dc.getConnection();
                con.Open();
                query = "SELECT * FROM Hotels.Departments WHERE DepartmentId = " + int.Parse(depIdField.Text) + " AND HotelId = " + Statics.hotelIdTKN;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    departmentNameField.Text = dr.GetString(1);
                    descriptionField.Text = dr.GetString(2);
                    salaryField.Text = dr.GetInt32(3).ToString();
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("No record found.");
                con.Close();
            }
        }

        private void employeeIdField_TextChanged(object sender, EventArgs e)
        {

        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT DepartmentId AS ID, DepartmentName AS Name, DepartmentDescription AS Description, InitialSalary FROM Hotels.Departments WHERE HotelId = " + Statics.hotelIdTKN ;
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            departmentTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void hotelsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addButton.Enabled = false;
            depIdField.Text = departmentTable.SelectedRows[0].Cells[0].Value.ToString();
            departmentNameField.Text = departmentTable.SelectedRows[0].Cells[1].Value.ToString();
            descriptionField.Text = departmentTable.SelectedRows[0].Cells[2].Value.ToString();
            salaryField.Text = departmentTable.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DepartmentsScreen_Load(object sender, EventArgs e)
        {
            populateTable();
        }

    

        private void getFieldsData()
        {
            name = departmentNameField.Text;
            description = descriptionField.Text;
            salary = int.Parse(salaryField.Text);
        }

        private void clearFields()
        {
            depIdField.Text = "";
            departmentNameField.Text = "";
            salaryField.Text = "";
            descriptionField.Text = "";
        }

        private bool checker()
        {
            if (!Regex.Match(departmentNameField.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Department name must contain alpabets and space only.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                departmentNameField.Focus();
                return false;
            }
            if (!Regex.Match(salaryField.Text, @"^[0-9]+$").Success)
            {
                MessageBox.Show("Salary field must contain numbers.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                salaryField.Focus();
                return false;
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (depIdField.Text != "" && departmentNameField.Text != "" && descriptionField.Text != "" && salaryField.Text != "")
            {
                bool regCheck = checker();
                if (regCheck == false)
                {
                    return;
                }
                getFieldsData();
                query = "INSERT INTO Hotels.Departments (DepartmentName, DepartmentDescription, InitialSalary, HotelId) VALUES ('" + name + "' , '" + description + "', " + salary + ", " + Statics.hotelIdTKN + ")";
                dc.setData(query, "Department inserted successfully!");
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            clearFields();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (depIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                setNullEmployeeDept();
                query = "DELETE FROM Hotels.Departments WHERE DepartmentId = " + int.Parse(depIdField.Text) + " AND HotelId = " + Statics.hotelIdTKN;
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

        private void setNullEmployeeDept()
        {
            query = "UPDATE Hotels.Employees SET DepartmentId = NULL WHERE DepartmentId = " + depIdField.Text;
            dc.setData(query, "");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            if (depIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool regCheck = checker();
                if (regCheck == false)
                {
                    return;
                }
                getFieldsData();
                query = "UPDATE Hotels.Departments SET DepartmentName = '" + name + "', DepartmentDescription = '" + description + "', InitialSalary= " + salary + " WHERE DepartmentId = " + int.Parse(depIdField.Text) + " AND HotelId = " + Statics.hotelIdTKN;
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesScreen es = new EmployeesScreen();
            es.populateDepartmentComboBox();
        }
    }
}

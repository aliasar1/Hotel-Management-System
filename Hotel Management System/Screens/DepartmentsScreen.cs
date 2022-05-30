﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
                query = "SELECT * FROM Hotels.Departments WHERE DepartmentId = " + int.Parse(depIdField.Text);
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
            String query = "SELECT DepartmentId AS ID, DepartmentName AS Name, DepartmentDescription AS Description, InitialSalary FROM Hotels.Departments";
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (depIdField.Text != "" || departmentNameField.Text != "" || descriptionField.Text != "" || salaryField.Text != "")
            {
                getFieldsData();
                query = "INSERT INTO Hotels.Departments (DepartmentName, DepartmentDescription, InitialSalary) VALUES ('" + name + "' , '" + description + "', " + salary + ")";
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
                query = "DELETE FROM Hotels.Departments WHERE DepartmentId = " + int.Parse(depIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
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
                getFieldsData();
                query = "UPDATE Hotels.Departments SET DepartmentName = '" + name + "', DepartmentDescription = '" + description + "', InitialSalary= " + salary + " WHERE DepartmentId = " + int.Parse(depIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
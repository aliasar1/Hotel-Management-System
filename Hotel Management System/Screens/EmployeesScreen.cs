using Hotel_Management_System.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Controllers
{
    public partial class EmployeesScreen : Form
    {

        DatabaseConnection dc = new DatabaseConnection();
        String query;

        public static int maxId;
        private Int32 id;
        private String fname;
        private String lname;
        private String email;
        private String cnic;
        private String zip;
        private String address;
        private String city;
        private String street;
        private String contact;

        public EmployeesScreen()
        {
            InitializeComponent();
        }

        private void getFieldsData()
        {
            fname = fnameField.Text;
            lname = lnameField.Text;
            email = emailField.Text;
            zip = zipField.Text;
            address = addressField.Text;
            city = cityField.Text;
            street = streetField.Text;
            contact = contactField.Text;
            cnic = cnicField.Text;
            findDepUsingId();
        }

        private void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT EmployeeId AS ID, EmployeeFirstName AS FName, EmployeeLastName AS LName, CNIC, EmployeeDesignation AS Designation, EmployeeContactNumber AS Contact, EmployeeEmailAddress AS Email, EmployeeJoingDate AS JDate, DepartmentId AS DepId, HotelId FROM Hotels.Employees";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            employeeTable.DataSource = ds.Tables[0];
            con.Close();
        }

        private void clearFields()
        {
            employeeIdField.Text = "";
            lnameField.Text = "";
            fnameField.Text = "";
            emailField.Text = "";
            depIdCMBox.SelectedIndex = -1;
            cnicField.Text = "";
            zipField.Text = "";
            addressField.Text = "";
            cityField.Text = "";
            streetField.Text = "";
            designationCMBox.SelectedIndex = -1;
            contactField.Text = "";
            
        }

        public void findDepUsingId()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT DepartmentId from Hotels.Departments WHERE DepartmentName = '" + depIdCMBox.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
        }

        private void populateDepartmentComboBox()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT DepartmentName from Hotels.Departments";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                depIdCMBox.Items.Add(dr["DepartmentName"]);
            }
            con.Close();
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            if (employeeIdField.Text != "" || fnameField.Text != "" || lnameField.Text != "" || emailField.Text != "" || depIdCMBox.SelectedIndex != -1 ||
                cnicField.Text != "" || zipField.Text != "" || addressField.Text != "" || cityField.Text != "" || streetField.Text != ""
                || designationCMBox.SelectedIndex != -1 || contactField.Text != "")
            {
                Console.WriteLine(depIdCMBox.Text);
                if (designationCMBox.Text == "Manager" || depIdCMBox.Text == "HR" || depIdCMBox.Text == "Accounts")
                {
                    getFieldsData();
                    query = "INSERT INTO Hotels.Employees (EmployeeFirstName, EmployeeLastName, EmployeeDesignation, EmployeeContactNumber, EmployeeEmailAddress, EmployeeJoingDate, AddressLine, Street, City, Zip, DepartmentId, HotelId, CNIC) VALUES ('" + fname + "' , '" + lname + "', '" + designationCMBox.Text + "' , '" + contact + "' , '" + email + "' , '" + joiningDatePicker.Text + "' , '" + address + "' , '" + street + "' , '" + city + "' , '" + zip + "' ," + id + ", " + 4 + ", '" + cnic + "')";
                    dc.setData(query, "You are required to create account in order to register.!");
                   
                    SqlConnection con = dc.getConnection();
                    con.Open();
                    query = "SELECT MAX(EmployeeId) FROM Hotels.Employees"; 
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        maxId = dr.GetInt32(0);
                    }
                    CreateEmployeeAccountScreen createEmployee = new CreateEmployeeAccountScreen();
                    createEmployee.Show();
                    
                }
                else
                {
                    getFieldsData();
                    query = "INSERT INTO Hotels.Employees (EmployeeFirstName, EmployeeLastName, EmployeeDesignation, EmployeeContactNumber, EmployeeEmailAddress, EmployeeJoingDate, AddressLine, Street, City, Zip, DepartmentId, HotelId, CNIC) VALUES ('" + fname + "' , '" + lname + "', '" + designationCMBox.Text + "' , '" + contact + "' , '" + email + "' , '" + joiningDatePicker.Text + "' , '" + address + "' , '" + street + "' , '" + city + "' , '" + zip + "' ," + id + ", " + 4 + ", '" + cnic + "')";
                    dc.setData(query, "Employee record inserted successfully!");
                }
                clearFields();
                populateTable();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
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

        private void EmployeesScreen_Load(object sender, EventArgs e)
        {
            populateTable();
            populateDepartmentComboBox();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}

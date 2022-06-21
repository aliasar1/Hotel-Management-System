using Hotel_Management_System.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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

        public void populateTable()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            String query = "SELECT EmployeeId AS ID, EmployeeFirstName AS FName, EmployeeLastName AS LName, CNIC, EmployeeDesignation AS Designation, EmployeeContactNumber AS Contact, EmployeeEmailAddress AS Email, EmployeeJoiningDate AS JDate, DepartmentId AS DepId, HotelId FROM Hotels.Employees WHERE HotelId = " + Statics.hotelIdTKN;
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

        public void populateDepartmentComboBox()
        {
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT DepartmentName from Hotels.Departments WHERE HotelId = " + Statics.hotelIdTKN;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                depIdCMBox.Items.Add(dr["DepartmentName"]);
            }
            con.Close();
        }

        private bool checkUniqueEmail()
        {
            query = "SELECT EmployeeId FROM Hotels.Employees WHERE EmployeeEmailAddress = '" + emailField.Text + "'";
            SqlConnection con = dc.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            if (id == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkUniqueCnic()
        {
            query = "SELECT EmployeeId FROM Hotels.Employees WHERE CNIC = '" + cnicField.Text + "'";
            SqlConnection con = dc.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            if (id == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkUnique()
        {
            bool c1 = checkUniqueEmail();
            if (c1 == false)
            {
                MessageBox.Show("Employee with same email already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailField.Focus();
                return false;
            }
            bool c2 = checkUniqueCnic();
            if (c2 == false)
            {
                MessageBox.Show("Employee with same cnic already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cnicField.Focus();
                return false;
            }
            return true;
        }

        private bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool regChecker()
        {
            if (!Regex.Match(contactField.Text, @"^[0-9]+$").Success)
            {
                MessageBox.Show("Contact number must only contain numbers.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contactField.Focus();
                return false;
            }
            if (!Regex.Match(zipField.Text, @"^\d{5}$").Success)
            {
                MessageBox.Show("Zipcode must only contain numbers with length of 5.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zipField.Focus();
                return false;
            }
            if (!Regex.Match(fnameField.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("First name can only contain alphabets and spaces if required.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fnameField.Focus();
                return false;
            }
            if (!Regex.Match(lnameField.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("Last name can only contain alphabets and spaces if required.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lnameField.Focus();
                return false;
            }
            if (!Regex.Match(cityField.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)
            {
                MessageBox.Show("City field must contain alpabets or space only.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cityField.Focus();
                return false;
            }
            return true;
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            if (fnameField.Text != "" && lnameField.Text != "" && emailField.Text != "" && depIdCMBox.SelectedIndex != -1 &&
                cnicField.Text != "" && zipField.Text != "" && addressField.Text != "" && cityField.Text != "" && streetField.Text != ""
                && designationCMBox.SelectedIndex != -1 && contactField.Text != "")
            {
                bool check = checkUnique();
                if (check == false)
                {
                    return;
                }
                bool emailCheck = IsValid(emailField.Text);
                if (emailCheck == false)
                {
                    MessageBox.Show("Invalid email format entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool regCheck = regChecker();
                if (regCheck == false)
                {
                    return;
                }
                if (designationCMBox.Text == "Manager" || depIdCMBox.Text == "HR" || depIdCMBox.Text == "Accounts" || depIdCMBox.Text == "IT" || depIdCMBox.Text == "Admin")
                {
                    getFieldsData();
                    query = "INSERT INTO Hotels.Employees (EmployeeFirstName, EmployeeLastName, EmployeeDesignation, EmployeeContactNumber, EmployeeEmailAddress, EmployeeJoiningDate, AddressLine, Street, City, Zip, DepartmentId, HotelId, CNIC) VALUES ('" + fname + "' , '" + lname + "', '" + designationCMBox.Text + "' , '" + contact + "' , '" + email + "' , '" + joiningDatePicker.Text + "' , '" + address + "' , '" + street + "' , '" + city + "' , '" + zip + "' ," + id + ", " + Statics.hotelIdTKN + ", '" + cnic + "')";
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
                    Statics.setTempEmplId(maxId);
                    Statics.EmployeeNameId(maxId, fnameField.Text);
             
                    ShowDefaultScreen screen = new ShowDefaultScreen(true);
                    screen.Show();
                    populateTable();
                }
                else
                {
                    getFieldsData();
                    query = "INSERT INTO Hotels.Employees (EmployeeFirstName, EmployeeLastName, EmployeeDesignation, EmployeeContactNumber, EmployeeEmailAddress, EmployeeJoiningDate, AddressLine, Street, City, Zip, DepartmentId, HotelId, CNIC) VALUES ('" + fname + "' , '" + lname + "', '" + designationCMBox.Text + "' , '" + contact + "' , '" + email + "' , '" + joiningDatePicker.Text + "' , '" + address + "' , '" + street + "' , '" + city + "' , '" + zip + "' ," + id + ", " + Statics.hotelIdTKN + ", '" + cnic + "')";
                    dc.setData(query, "Employee record inserted successfully!");
                    populateTable();
                }
                clearFields();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void getRecenetEmpId()
        {
            query = "SELECT MAX(EmployeeId) FROM Hotels.Employees";
            SqlConnection con = dc.getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maxId = dr.GetInt32(0);
            }
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            fetchEmployeeRecord(0);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.loadForm(new HotelIntroScreen());
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

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fetchEmployeeRecord(1);
           
        }

        private void fetchEmployeeRecord(int i)
        {
            String idEmp;
            if (i == 1)
            {
                idEmp = employeeTable.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                idEmp = employeeIdField.Text;
            }
            SqlConnection con = dc.getConnection();
            con.Open();
            query = "SELECT * FROM Hotels.Employees WHERE EmployeeId = " + idEmp;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                employeeIdField.Text = idEmp;
                fnameField.Text = dr.GetString(1);
                lnameField.Text = dr.GetString(2);
                designationCMBox.Text = dr.GetString(3);
                contactField.Text = dr.GetString(4);
                Console.WriteLine(dr.GetString(5));
                emailField.Text = dr.GetString(5);
                joiningDatePicker.Value = Convert.ToDateTime(dr["EmployeeJoiningDate"]);
                addressField.Text = dr.GetString(7);
                streetField.Text = dr.GetString(8);
                cityField.Text = dr.GetString(9);
                zipField.Text = dr.GetString(10);
                depIdCMBox.Text = findDepUsingId(dr.GetValue(11).ToString());
                cnicField.Text = dr.GetString(13);
            }

        }

        public String findDepUsingId(String s)
        {
            if (!s.Equals(""))
            {
                SqlConnection con = dc.getConnection();
                con.Open();
                String str = "";
                query = "SELECT DepartmentName from Hotels.Departments WHERE DepartmentId = " + s;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    str = dr.GetString(0);
                }
                return str;
            }
            return "null";
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (employeeIdField.Text == "")
            {
                MessageBox.Show("Please enter id to update record.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                bool regCheck = regChecker();
                if (regCheck == false)
                {
                    return;
                }
                getFieldsData();
                query = "UPDATE Hotels.Employees SET EmployeeFirstName = '" + fnameField.Text + "', EmployeeLastName = '" + lnameField.Text + "', EmployeeDesignation = '" + designationCMBox.Text + "', EmployeeContactNumber = '" + contactField.Text + "', EmployeeEmailAddress = '" + emailField.Text + "', EmployeeJoiningDate = '" + joiningDatePicker.Text + "', AddressLine = '" + addressField.Text + "', Street = '" + streetField.Text + "', City = '" + cityField.Text + "', Zip = '" + zipField.Text + "', CNIC = '" + cnicField.Text + "', DepartmentId = '" + id + "' WHERE EmployeeId = " + int.Parse(employeeIdField.Text);
                dc.setData(query, "Record updated successfully.");
                clearFields();
                populateTable();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeeIdField.Text == "")
            {
                MessageBox.Show("Please enter id to delete.", "Missing Info", MessageBoxButtons.OK);
            }
            else
            {
                query = "DELETE FROM Hotels.Employees WHERE EmployeeId = " + int.Parse(employeeIdField.Text);
                dc.setData(query, "Record deleted successfully.");
                clearFields();
                populateTable();
            }
        }

    }
}

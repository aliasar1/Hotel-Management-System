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
    public partial class RoomsScreen : Form
    {
        public RoomsScreen()
        {
            InitializeComponent();
            searchButton.Enabled = false;
        }

        private void Rooms_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            searchButton.Enabled = true;
            roomIdField.ReadOnly = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            roomIdField.ReadOnly = true;
            addButton.Enabled = true;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            searchButton.Enabled = false;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }
    }
}

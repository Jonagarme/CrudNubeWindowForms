using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudNube
{
    public partial class MainForm : Form
    {
        private string currentUser;
        private string currentRole;

        public MainForm(string user, string role)
        {
            InitializeComponent();
            this.currentUser = user;
            this.currentRole = role;

            lblWelcome.Text = $"Bienvenido, {currentUser} ({currentRole})";

            // Ocultar opciones si no es Admin
            if (currentRole != "Admin")
            {
                btnManageUsers.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.ShowDialog();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProductsForm manageProductsForm = new ManageProductsForm();
            manageProductsForm.ShowDialog();
        }


    }
}

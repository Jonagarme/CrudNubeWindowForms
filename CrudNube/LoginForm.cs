using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CrudNube
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Inicio de Sesión - CrudNube";
            this.Size = new System.Drawing.Size(500, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string userRole = GetUserRole(username, password); // Obtener el rol desde la BD

            if (!string.IsNullOrEmpty(userRole))
            {
                MessageBox.Show($"Bienvenido, {username} ({userRole})", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MainForm mainForm = new MainForm(username, userRole); // Pasar datos al MainForm
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string GetUserRole(string username, string password)
        {
            string role = "";

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Rol FROM USUARIOS WHERE Usuario = @Usuario AND Clave = @Clave AND Estado = 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", username);
                        cmd.Parameters.AddWithValue("@Clave", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            role = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener rol del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return role;
        }


        //private bool ValidateUser(string username, string password)
        //{
        //    bool isValid = false;
        //    try
        //    {
        //        using (SqlConnection conn = Database.GetConnection())
        //        {
        //            conn.Open();
        //            string query = "SELECT COUNT(*) FROM USUARIOS WHERE Usuario = @Usuario AND Clave = @Clave";
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@Usuario", username);
        //                cmd.Parameters.AddWithValue("@Clave", password);

        //                int count = (int)cmd.ExecuteScalar();
        //                isValid = count > 0;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al validar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return isValid;
        //}



        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // Muestra el formulario de registro como moda

        }
    }
}

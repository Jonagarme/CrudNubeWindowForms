using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CrudNube
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Se carga la imagen en el PictureBox
                picPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Recupera los datos de los controles
            string nombre = txtName.Text;
            string usuario = txtUsername.Text;
            string email = txtEmail.Text;
            string clave = txtPassword.Text;
            string rol = cbRole.SelectedItem?.ToString();
            bool estado = chkActive.Checked;

            // Verifica que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(clave) ||
                string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Supone que tienes una clase Database con el método GetConnection() que devuelve una conexión SQL
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_CrearUsuario", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Clave", clave);
                        cmd.Parameters.AddWithValue("@Rol", rol);
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario registrado con éxito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

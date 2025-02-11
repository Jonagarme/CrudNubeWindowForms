using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CrudNube
{
    partial class RegisterForm
    {
        // Declaración de controles
        private Label lblName, lblUsername, lblEmail, lblPassword, lblRole, lblPhoto;
        private TextBox txtName, txtUsername, txtEmail, txtPassword;
        private ComboBox cbRole;
        private CheckBox chkActive;
        private Button btnUploadPhoto, btnRegister;
        private PictureBox picPhoto;

        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método necesario para el soporte del Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Text = "Registro de Usuario";
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 36);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Crear e inicializar lblName
            this.lblName = new System.Windows.Forms.Label();
            this.lblName.Text = "Nombre:";
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(30, 30);

            // Crear e inicializar lblUsername
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsername.Text = "Usuario:";
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(30, 80);

            // Crear e inicializar lblEmail
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmail.Text = "Email:";
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(30, 130);

            // Crear e inicializar lblPassword
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(30, 180);

            // Crear e inicializar lblRole
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRole.Text = "Rol:";
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(30, 230);

            // Crear e inicializar lblPhoto
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblPhoto.Text = "Foto:";
            this.lblPhoto.ForeColor = System.Drawing.Color.White;
            this.lblPhoto.Location = new System.Drawing.Point(30, 280);

            // Crear e inicializar txtName
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtName.Location = new System.Drawing.Point(150, 30);
            this.txtName.Width = 250;

            // Crear e inicializar txtUsername
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUsername.Location = new System.Drawing.Point(150, 80);
            this.txtUsername.Width = 250;

            // Crear e inicializar txtEmail
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmail.Location = new System.Drawing.Point(150, 130);
            this.txtEmail.Width = 250;

            // Crear e inicializar txtPassword
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword.Location = new System.Drawing.Point(150, 180);
            this.txtPassword.Width = 250;
            this.txtPassword.UseSystemPasswordChar = true;

            // Crear e inicializar cbRole
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbRole.Location = new System.Drawing.Point(150, 230);
            this.cbRole.Width = 250;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Items.AddRange(new object[] { "Admin", "Usuario", "Supervisor" });

            // Crear e inicializar chkActive
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.chkActive.Text = "Activo";
            this.chkActive.ForeColor = System.Drawing.Color.White;
            this.chkActive.Location = new System.Drawing.Point(150, 260);

            // Crear e inicializar btnUploadPhoto
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.btnUploadPhoto.Text = "Subir Foto";
            this.btnUploadPhoto.Location = new System.Drawing.Point(150, 280);
            this.btnUploadPhoto.Width = 120;
            this.btnUploadPhoto.BackColor = System.Drawing.Color.FromArgb(34, 177, 76);
            this.btnUploadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnUploadPhoto.Click += new System.EventHandler(this.BtnUploadPhoto_Click);

            // Crear e inicializar picPhoto
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.picPhoto.Location = new System.Drawing.Point(280, 280);
            this.picPhoto.Size = new System.Drawing.Size(100, 100);
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhoto.BackColor = System.Drawing.Color.White;

            // Crear e inicializar btnRegister
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegister.Text = "Registrar";
            this.btnRegister.Location = new System.Drawing.Point(150, 390);
            this.btnRegister.Width = 120;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);

            // Agregar controles al formulario
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.btnRegister);
        }



    }
}

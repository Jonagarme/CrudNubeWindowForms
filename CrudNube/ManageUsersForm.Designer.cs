using System.Windows.Forms;

namespace CrudNube
{
    partial class ManageUsersForm
    {
        private DataGridView dgvUsers;
        private ComboBox cbRoles;
        private Button btnUpdateRole;


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.btnUpdateRole = new System.Windows.Forms.Button();

            // dgvUsers
            this.dgvUsers.Location = new System.Drawing.Point(20, 20);
            this.dgvUsers.Size = new System.Drawing.Size(500, 250);
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // cbRoles
            this.cbRoles.Location = new System.Drawing.Point(20, 280);
            this.cbRoles.Size = new System.Drawing.Size(200, 25);
            this.cbRoles.Items.AddRange(new string[] { "Admin", "Usuario", "Supervisor" });

            // btnUpdateRole
            this.btnUpdateRole.Location = new System.Drawing.Point(250, 280);
            this.btnUpdateRole.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateRole.Text = "Actualizar Rol";
            this.btnUpdateRole.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnUpdateRole.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);

            // ManageUsersForm
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Text = "Gestión de Usuarios";
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.btnUpdateRole);
        }

        #endregion
    }
}
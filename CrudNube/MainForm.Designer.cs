using System.Windows.Forms;

namespace CrudNube
{
    partial class MainForm
    {
        private Label lblWelcome;
        private Button btnLogout;
        private Button btnManageUsers;
        private Button btnManageProducts;

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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "Panel Principal - CrudNube";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(200, 24);
            this.lblWelcome.Text = "Bienvenido";

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(650, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 35);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 20, 60);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // btnManageUsers
            this.btnManageUsers.Location = new System.Drawing.Point(20, 80);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(180, 40);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Gestión de Usuarios";
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(34, 177, 76);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);

            // btnManageProducts
            this.btnManageProducts.Location = new System.Drawing.Point(20, 140);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(180, 40);
            this.btnManageProducts.TabIndex = 3;
            this.btnManageProducts.Text = "Gestión de Productos";
            this.btnManageProducts.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnManageProducts.ForeColor = System.Drawing.Color.White;
            this.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);

            // Agregar controles
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageProducts);
        }


        #endregion
    }
}
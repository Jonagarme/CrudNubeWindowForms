namespace CrudNube
{
    partial class ManageProductsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            // ManageProductsForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "Gestión de Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 24);
            this.lblTitle.Text = "Lista de Productos";

            // dgvProducts
            this.dgvProducts.Location = new System.Drawing.Point(20, 60);
            this.dgvProducts.Size = new System.Drawing.Size(750, 300);
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // btnNewProduct
            this.btnNewProduct.Location = new System.Drawing.Point(20, 380);
            this.btnNewProduct.Size = new System.Drawing.Size(160, 40);
            this.btnNewProduct.Text = "Nuevo Producto";
            this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(34, 177, 76);
            this.btnNewProduct.ForeColor = System.Drawing.Color.White;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);

            // btnEditProduct
            this.btnEditProduct.Location = new System.Drawing.Point(200, 380);
            this.btnEditProduct.Size = new System.Drawing.Size(160, 40);
            this.btnEditProduct.Text = "Editar Producto";
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);

            // Agregar controles
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.btnEditProduct);
        }
    }
}

using System.Windows.Forms;

namespace CrudNube
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle, lblCodigo, lblNombre, lblDescripcion, lblFoto, lblPrecio, lblStock, lblCategoria, lblProveedor;
        private TextBox txtCodigo, txtNombre, txtDescripcion, txtFoto, txtPrecio, txtStock;
        private ComboBox cbCategoria, cbProveedor;
        private Button btnSave, btnCancel, btnUploadPhoto;
        private PictureBox picPhoto;

        /// <summary>
        /// Limpia los recursos en uso.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; de lo contrario, false.</param>
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
        /// Método requerido para el diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblCodigo = new Label();
            this.lblNombre = new Label();
            this.lblDescripcion = new Label();
            this.lblFoto = new Label();
            this.lblPrecio = new Label();
            this.lblStock = new Label();
            this.lblCategoria = new Label();
            this.lblProveedor = new Label();

            this.txtCodigo = new TextBox();
            this.txtNombre = new TextBox();
            this.txtDescripcion = new TextBox();
            this.txtFoto = new TextBox();
            this.txtPrecio = new TextBox();
            this.txtStock = new TextBox();

            this.cbCategoria = new ComboBox();
            this.cbProveedor = new ComboBox();

            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.btnUploadPhoto = new Button();

            this.picPhoto = new PictureBox();

            // Configuración del formulario
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Text = "Gestión de Producto";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);

            // (IMPORTANTE) No llamamos a ConfigureControls() aquí
            // ConfigureControls();

            // Agregar controles al formulario
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
        }

        #endregion
    }
}

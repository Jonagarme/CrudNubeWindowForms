using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CrudNube
{
    public partial class ProductForm : Form
    {
        private int? productId = null;

        public ProductForm()
        {
            InitializeComponent();
            ConfigureControls();
            LoadCategories();
            LoadProviders();
            lblTitle.Text = "Crear Producto";
            btnSave.Text = "Guardar Producto";
        }

        // Constructor para editar un producto existente
        public ProductForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            ConfigureControls();
            LoadCategories();
            LoadProviders();
            LoadProductData();
            lblTitle.Text = "Editar Producto";
            btnSave.Text = "Actualizar Producto";
        }

        private void LoadProductData()
        {
            if (productId == null) return;

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Codigo, Nombre, Descripcion, Foto, Precio, Stock, CategoriaID, ProveedorID FROM PRODUCTOS WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", productId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCodigo.Text = reader["Codigo"].ToString();
                                txtNombre.Text = reader["Nombre"].ToString();
                                txtDescripcion.Text = reader["Descripcion"].ToString();
                                txtFoto.Text = reader["Foto"].ToString();
                                txtPrecio.Text = reader["Precio"].ToString();
                                txtStock.Text = reader["Stock"].ToString();
                                cbCategoria.SelectedValue = reader["CategoriaID"];
                                cbProveedor.SelectedValue = reader["ProveedorID"];

                                if (!string.IsNullOrEmpty(txtFoto.Text) && System.IO.File.Exists(txtFoto.Text))
                                {
                                    picPhoto.Image = Image.FromFile(txtFoto.Text);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ID, Nombre FROM Categorias", conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbCategoria.DataSource = dt;
                        cbCategoria.DisplayMember = "Nombre";
                        cbCategoria.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProviders()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ID, Nombre FROM Proveedores", conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbProveedor.DataSource = dt;
                        cbProveedor.DisplayMember = "Nombre";
                        cbProveedor.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFoto.Text = openFileDialog.FileName;
                picPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string foto = txtFoto.Text;
            decimal precio;
            int stock;
            int categoriaId = Convert.ToInt32(cbCategoria.SelectedValue);
            int proveedorId = Convert.ToInt32(cbProveedor.SelectedValue);

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(descripcion) || !decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Todos los campos son obligatorios y deben ser válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(productId == null ? "sp_CrearProducto" : "sp_EditarProducto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (productId != null)
                        {
                            cmd.Parameters.AddWithValue("@ID", productId);
                        }

                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Foto", foto);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@CategoriaID", categoriaId);
                        cmd.Parameters.AddWithValue("@ProveedorID", proveedorId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigureControls()
        {
            // Ampliamos el ancho del formulario para acomodar la imagen a la derecha
            this.ClientSize = new System.Drawing.Size(650, 600);

            int labelX = 20, inputX = 150, spacingY = 40, startY = 60;

            // Título
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new System.Drawing.Point(labelX, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Gestión de Producto";

            // Configuración de Labels
            SetLabelProperties(lblCodigo, "Código:", labelX, startY);
            SetLabelProperties(lblNombre, "Nombre:", labelX, startY + spacingY);
            SetLabelProperties(lblDescripcion, "Descripción:", labelX, startY + spacingY * 2);
            SetLabelProperties(lblFoto, "Foto:", labelX, startY + spacingY * 3);
            SetLabelProperties(lblPrecio, "Precio:", labelX, startY + spacingY * 4);
            SetLabelProperties(lblStock, "Stock:", labelX, startY + spacingY * 5);
            SetLabelProperties(lblCategoria, "Categoría:", labelX, startY + spacingY * 6);
            SetLabelProperties(lblProveedor, "Proveedor:", labelX, startY + spacingY * 7);

            // TextBoxes
            SetTextBoxProperties(txtCodigo, inputX, startY);
            SetTextBoxProperties(txtNombre, inputX, startY + spacingY);
            SetTextBoxProperties(txtDescripcion, inputX, startY + spacingY * 2);

            // -- Ajuste de "Foto" para ir en la misma línea --
            // Disminuimos un poco el ancho para dejar espacio al botón y al PictureBox
            txtFoto.Location = new System.Drawing.Point(inputX, startY + spacingY * 3);
            txtFoto.Size = new System.Drawing.Size(200, 25);

            SetTextBoxProperties(txtPrecio, inputX, startY + spacingY * 4);
            SetTextBoxProperties(txtStock, inputX, startY + spacingY * 5);

            // ComboBoxes
            SetComboBoxProperties(cbCategoria, inputX, startY + spacingY * 6);
            SetComboBoxProperties(cbProveedor, inputX, startY + spacingY * 7);

            // Botón “Subir Foto”, justo a la derecha del TextBox "Foto"
            btnUploadPhoto.Text = "Subir Foto";
            btnUploadPhoto.Location = new System.Drawing.Point(inputX + 210, startY + spacingY * 3);
            btnUploadPhoto.Size = new System.Drawing.Size(80, 25);
            btnUploadPhoto.BackColor = Color.FromArgb(34, 177, 76);
            btnUploadPhoto.ForeColor = Color.White;
            btnUploadPhoto.FlatStyle = FlatStyle.Flat;
            btnUploadPhoto.Click += new EventHandler(this.btnUploadPhoto_Click);

            // PictureBox a la derecha del botón
            picPhoto.Location = new System.Drawing.Point(inputX + 300, startY + spacingY * 3);
            picPhoto.Size = new System.Drawing.Size(100, 80);
            picPhoto.BorderStyle = BorderStyle.FixedSingle;
            picPhoto.BackColor = Color.White;

            // Botón Guardar/Actualizar
            btnSave.Location = new System.Drawing.Point(50, startY + spacingY * 8 + 50);
            btnSave.Size = new System.Drawing.Size(150, 40);
            btnSave.BackColor = Color.FromArgb(0, 120, 215);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Click += new EventHandler(this.btnSave_Click);

            // Botón Cancelar
            btnCancel.Location = new System.Drawing.Point(230, startY + spacingY * 8 + 50);
            btnCancel.Size = new System.Drawing.Size(150, 40);
            btnCancel.BackColor = Color.FromArgb(220, 20, 60);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Text = "Cancelar";
            btnCancel.Click += new EventHandler(this.btnCancel_Click);
        }

        private void SetLabelProperties(Label label, string text, int x, int y)
        {
            label.Location = new System.Drawing.Point(x, y);
            label.Text = text;
            label.ForeColor = Color.White;
            label.AutoSize = true;
        }

        private void SetTextBoxProperties(TextBox textBox, int x, int y)
        {
            textBox.Location = new System.Drawing.Point(x, y);
            textBox.Size = new System.Drawing.Size(250, 25);
        }

        private void SetComboBoxProperties(ComboBox comboBox, int x, int y)
        {
            comboBox.Location = new System.Drawing.Point(x, y);
            comboBox.Size = new System.Drawing.Size(250, 25);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}

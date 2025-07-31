using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using datos;

namespace presentacion
{
    public partial class FormABM : Form
    {
        private Articulo _articulo = null;
        #region Constructores
        public FormABM() //ALTA ARTICULO
        {
            InitializeComponent();
            OcultarFlp();
        }

        public FormABM(Articulo articulo) //MODIFICAR ARTICULO
        {
            InitializeComponent();
            _articulo = articulo;
            Text = "Modificar Artículo";
            OcultarFlp();
        }
        #endregion

        private void FormABM_Load(object sender, EventArgs e)
        {
            ArticuloDB db = new ArticuloDB();
            try
            {
                cboCategoria.DataSource = db.ListarCategoria();
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "Id";
                cboMarca.DataSource = db.ListarMarca();
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.ValueMember = "Id";
                if (_articulo != null) //MODIFICAR ARTICULO
                {
                    txtNombre.Text = _articulo.Nombre;
                    txtCodigo.Text = _articulo.Codigo;
                    txtDescripcion.Text = _articulo.Descripcion;
                    txtUrl.Text = _articulo.Url_imagen;
                    txtPrecio.Text = _articulo.Precio.ToString();
                    var indexCategoria = cboCategoria.FindString(_articulo.Categoria.Descripcion);
                    cboCategoria.SelectedIndex = indexCategoria;
                    var indexMarca = cboMarca.FindString(_articulo.Marca.Descripcion);
                    cboMarca.SelectedIndex = indexMarca;
                }
                else
                {
                    cboCategoria.SelectedIndex = -1;
                    cboMarca.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!EsValido() && _articulo == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }
            ArticuloDB db = new ArticuloDB();
            try
            {
                if (_articulo == null) //ALTA ARTICULO
                    _articulo = new Articulo();
                _articulo.Nombre = txtNombre.Text;
                _articulo.Codigo = txtCodigo.Text;
                _articulo.Marca = (Marca)cboMarca.SelectedItem;
                _articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                _articulo.Descripcion = txtDescripcion.Text;
                _articulo.Url_imagen = txtUrl.Text;
                _articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (_articulo.Id == 0)
                {
                    db.Agregar(_articulo);
                    MessageBox.Show("Artículo agregado correctamente.");
                }
                else
                {
                    db.Modificar(_articulo);
                    MessageBox.Show("Artículo modificado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        private void CargarImagen(string url)
        {
            try
            {
                pbxArticulo.Load(url);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://cdn-icons-png.flaticon.com/512/85/85488.png");
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrl.Text);
        }

        private void AltaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Imagenes|*.jpg;*.jpeg;*.png;";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }

        }

        #region Validaciones
        private bool EsValido()
        {
            OcultarFlp();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                valido = false;
                flpErrorNombre.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                valido = false;
                flpErrorCodigo.Visible = true;
            }
            if (cboCategoria.SelectedIndex == -1)
            {
                valido = false;
                flpErrorCategoria.Visible = true;
            }
            if (cboMarca.SelectedIndex == -1)
            {
                valido = false;
                flpErrorMarca.Visible = true;
            }
            if (string.IsNullOrWhiteSpace(txtPrecio.Text) || !decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                valido = false;
                flpErrorPrecio.Visible = true;
            }
            return valido;
        }
        private void OcultarFlp() 
        {
            flpErrorCodigo.Visible = false;
            flpErrorCategoria.Visible = false;
            flpErrorMarca.Visible = false;
            flpErrorPrecio.Visible = false;
            flpErrorNombre.Visible = false;
        }
        #endregion
    }
}

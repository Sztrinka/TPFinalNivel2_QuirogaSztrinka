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
        private Articulo articulo = null;
        public FormABM() //ALTA ARTICULO
        {
            InitializeComponent();
        }

        public FormABM(Articulo articulo) //MODIFICAR ARTICULO
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }
        private void FormABM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloDB articuloDB = new ArticuloDB();

            try
            {
                articulo.Nombre = txtNombre.Text;
                articulo.Codigo = txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Url_imagen = txtUrl.Text;
                articuloDB.Agregar(articulo);
            }
            catch (Exception ex)
            {

            }

        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Datos;

namespace TP_WinForm
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticulosDatos datos = new ArticulosDatos();
            
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = float.Parse(txtPrecio.Text);
                articulo.Marca = (MARCA)cboIDMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboIDCategoria.SelectedItem;

                datos.Agregar(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());// muestra msj del error
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaDatos marcadatos = new MarcaDatos();
            CategoriasDatos categoriasDatos = new CategoriasDatos();
            try
            {
                cboIDMarca.DataSource = marcadatos.listar();
                cboIDCategoria.DataSource = categoriasDatos.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

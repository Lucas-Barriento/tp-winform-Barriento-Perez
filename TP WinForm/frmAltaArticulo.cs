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
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo; //el que era null se le asigna el articulo seleccionado
            Text = "Modificar Articulo";
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
            
            ArticulosDatos datos = new ArticulosDatos();
            
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = double.Parse(txtPrecio.Text);
                articulo.Marca = (MARCA)cboIDMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboIDCategoria.SelectedItem;
                articulo.ImagenURL = txtURLImagen.Text;
               
                if (articulo.ID != 0){
                    datos.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    datos.Agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");

                }

                
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
              
                cboIDMarca.ValueMember = "Id";
                cboIDMarca.DisplayMember = "Descripcion";

               // cboIDMarca.DataSource = marcadatos.listar();

                cboIDCategoria.ValueMember = "Id";
                cboIDCategoria.DisplayMember = "Descripcion";
                // cboIDCategoria.DataSource = categoriasDatos.listar();
                cboIDMarca.DataSource = marcadatos.listar();
                cboIDCategoria.DataSource = categoriasDatos.listar();



                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtURLImagen.Text = articulo.ImagenURL;
                    cargarImagen(articulo.ImagenURL);
                    cboIDMarca.SelectedValue = articulo.Marca.id;
                    cboIDCategoria.SelectedValue = articulo.Categoria.ID;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtURLImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtURLImagen.Text);
        }
        private void cargarImagen(String imagen)
        {

            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                // muestra imagen por defecto si el articulo no tiene una
                pbxArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void txtURLImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboIDMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

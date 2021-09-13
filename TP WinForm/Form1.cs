using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm
{
    public partial class Form1 : Form
    {
        private List<Articulo> ListaArticulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticulosDatos datos= new ArticulosDatos();
            ListaArticulo = datos.Listar(); 
            dgvArticulos.DataSource = ListaArticulo;
            dgvArticulos.Columns["ImagenUrl"].Visible=false;
            cargarImagen(ListaArticulo[0].ImagenURL);           
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //de la fila actual trae el objeto enlazado, devuelve un objeto que se le asigna a Articulo seleccionado
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            cargarImagen(seleccionado.ImagenURL);
                }
        //funcion que carga la imagen
        private void cargarImagen(String imagen)
        {
            
            try
            {
                pictureBoxArticulos.Load(imagen);
            }
            catch (Exception )
            {
                // muestra imagen por defecto si el articulo no tiene una
                pictureBoxArticulos.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void pictureBoxArticulos_Click(object sender, EventArgs e)
        {

        }
    }
}

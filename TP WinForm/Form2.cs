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
using TP_WinForm;

namespace TP_WinForm
{
    public partial class frmBorrar : Form
    {
        private Articulo art = null;
        public frmBorrar()
        {
            InitializeComponent();
        }
        public frmBorrar(Articulo art)
        {
            this.art = art;
            InitializeComponent();
            List<Articulo> lista = new List<Articulo>();
            lista.Add(art);
            dgvBorrar.DataSource = lista;
            dgvBorrar.Columns["ImagenUrl"].Visible = false;
            dgvBorrar.Columns["id"].Visible = false;
            try
            {
                PcbBorrar.Load(art.ImagenURL);
            }
            catch (Exception)
            {
                // muestra imagen por defecto si el articulo no tiene una
                PcbBorrar.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }

        }

        private void labelBorrarSeguro_Click(object sender, EventArgs e)
        {

        }

        private void frmBorrar_Load(object sender, EventArgs e)
        {
            try
            {
                PcbBorrar.Load(art.ImagenURL);
            }
            catch (Exception)
            {
                // muestra imagen por defecto si el articulo no tiene una
                PcbBorrar.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }


        }

        private void PcbBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void BtnID_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            Articulo aux = new Articulo();
            try
            {
                datos.SetearConsulta("select a.id,Codigo,Nombre,M.id,M.Descripcion Marca,a.Descripcion,ImagenUrl,C.Id,C.Descripcion,A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where a.Id = @ID and C.id = A.IdCategoria and M.Id = A.IdMarca");
                datos.setearParametro("@ID",TxtIdBuscar.Text);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                   
                    aux.ID = (int)datos.Lector["id"];

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["ImagenUrl"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.ID = datos.Lector.GetInt32(7);
                    aux.Categoria.CategoriaDescripcion = datos.Lector.GetString(8);
                    aux.Marca = new MARCA();
                    aux.Marca.id = datos.Lector.GetInt32(3);
                    aux.Marca.marca = datos.Lector.GetString(4);

                    lista.Add(aux);
                }


                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

            dgvBuscar.DataSource = lista;
            dgvBuscar.Columns["ImagenURL"].Visible = false;
            try
            {
                pcbBucar.Load(aux.ImagenURL);
            }
            catch (Exception)
            {
                // muestra imagen por defecto si el articulo no tiene una
                pcbBucar.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }


        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            Articulo aux = new Articulo();
            try
            {
                datos.SetearConsulta("select a.id,Codigo,Nombre,M.id,M.Descripcion Marca,a.Descripcion,ImagenUrl,C.Id,C.Descripcion,A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where a.Codigo = @Codigo and C.id = A.IdCategoria and M.Id = A.IdMarca");
                datos.setearParametro("@Codigo", TxtCodigoBuscar.Text);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {

                    aux.ID = (int)datos.Lector["id"];

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["ImagenUrl"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.ID = datos.Lector.GetInt32(7);
                    aux.Categoria.CategoriaDescripcion = datos.Lector.GetString(8);
                    aux.Marca = new MARCA();
                    aux.Marca.id = datos.Lector.GetInt32(3);
                    aux.Marca.marca = datos.Lector.GetString(4);

                    lista.Add(aux);
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

            dgvBuscar.DataSource = lista;
            dgvBuscar.Columns["ImagenURL"].Visible = false;
            try
            {
                pcbBucar.Load(aux.ImagenURL);
            }
            catch (Exception)
            {
                // muestra imagen por defecto si el articulo no tiene una
                pcbBucar.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }

        }

        private void BtnNombre_Click(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            Articulo aux = new Articulo();
            try
            {
                datos.SetearConsulta("select a.id,Codigo,Nombre,M.id,M.Descripcion Marca,a.Descripcion,ImagenUrl,C.Id,C.Descripcion,A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where a.Nombre = @Nombre and C.id = A.IdCategoria and M.Id = A.IdMarca");
                datos.setearParametro("@Nombre", TxtNombreBuscar.Text);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {

                    aux.ID = (int)datos.Lector["id"];

                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["ImagenUrl"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.ID = datos.Lector.GetInt32(7);
                    aux.Categoria.CategoriaDescripcion = datos.Lector.GetString(8);
                    aux.Marca = new MARCA();
                    aux.Marca.id = datos.Lector.GetInt32(3);
                    aux.Marca.marca = datos.Lector.GetString(4);

                    lista.Add(aux);
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

            dgvBuscar.DataSource = lista;
            dgvBuscar.Columns["ImagenURL"].Visible = false;
            try
            {
                pcbBucar.Load(aux.ImagenURL);
            }
            catch (Exception)
            {
                // muestra imagen por defecto si el articulo no tiene una
                pcbBucar.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

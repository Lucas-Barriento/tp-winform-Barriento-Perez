using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Datos
{
    public class ArticulosDatos
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select a.id,Codigo,Nombre,M.Descripcion Marca,a.Descripcion,ImagenUrl,C.Descripcion,A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where C.id = A.IdCategoria and M.Id = A.IdMarca");
                datos.EjecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = (int)datos.Lector["id"];

                    if(!(datos.Lector["Codigo"] is DBNull))
                    aux.Codigo = (string)datos.Lector["Codigo"];

                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["ImagenUrl"];
                       
                   if (!(datos.Lector["Precio"] is DBNull))
                       /* aux.Precio = (float)datos.Lector["Precio"]; */

                    aux.Categoria = new Categoria();
                    aux.Categoria.CategoriaDescripcion = datos.Lector.GetString(6);
                    aux.Marca = new MARCA();
                    aux.Marca.marca = datos.Lector.GetString(3);

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }



        }

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdMarca,IdCategoria) values ('" + nuevo.Codigo+"','"+nuevo.Nombre+"','"+nuevo.Descripcion+"',"+nuevo.Precio+ ",@IdMarca,@IdCategoria)");
                datos.setearParametro("@IdMarca", nuevo.Marca.id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.ID);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar()
        {

        }
    }
}
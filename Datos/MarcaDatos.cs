using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Datos
{
    public class MarcaDatos
    {
        public List<MARCA> listar()
        {
            List<MARCA> lista = new List<MARCA>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("select id, Descripcion from MARCAS");
            datos.EjecutarLectura();

            try
            {
                while (datos.Lector.Read())
                {
                    MARCA aux = new MARCA();
                    aux.id = (int)datos.Lector["id"];
                    aux.marca = (string)datos.Lector["Descripcion"];
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


    }
}

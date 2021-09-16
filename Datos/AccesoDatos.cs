using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        //lectura desde el exterior:
        public SqlDataReader Lector { 
            get { return lector; }
        }

        //conexion:
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS;database=CATALOGO_DB;integrated security=true");
            comando = new SqlCommand();
        }
        //consulta:
        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void cerrarConexion()
        {
            if (Lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Datos
{
     public class CategoriasDatos
    { 
            public List<Categoria> listar()
            {
                List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetearConsulta("select Id, Descripcion from CATEGORIAS");
            datos.EjecutarLectura();
           
               try 
	        {	        
		    while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.ID = (int)datos.Lector["id"];
                    aux.CategoriaDescripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                
            return lista;
	        }
	        catch (Exception ex)
	        {

	        	throw ex;
	        }
            finally{
                datos.cerrarConexion();
            }
            }
    }
    
}

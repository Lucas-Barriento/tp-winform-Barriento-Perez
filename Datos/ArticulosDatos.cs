﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

//sin conexion centralizada:
/*
namespace Datos
{
    public class ArticulosDatos
    {
       
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;//no se crea instancia
            try
            {
                //conexion a db sql
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=CATALOGO_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "select a.id,Codigo,Nombre,Descripcion,ImagenUrl from ARTICULOS a ";
                //comando.CommandText = "select a.id,Codigo,Nombre,a.Descripcion,ImagenUrl,C.Descripcion from ARTICULOS A, CATEGORIAS C where C.id = A.IdCategoria";
                comando.CommandText =   "select a.id,Codigo,Nombre,M.Descripcion Marca,a.Descripcion,ImagenUrl,C.Descripcion from ARTICULOS A, CATEGORIAS C, MARCAS M where C.id = A.IdCategoria and M.Id = A.IdMarca";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    //pasa a objeto
                    Articulo aux = new Articulo();
                    aux.ID = (int)lector["id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.ImagenURL = (string)lector["ImagenUrl"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.CategoriaDescripcion = lector.GetString(6);
                    aux.Marca = new MARCA();
                    aux.Marca.marca = lector.GetString(3);
                    

                    lista.Add(aux); 
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}*/


//con conexion centralizada:
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
                datos.SetearConsulta("select a.id,Codigo,Nombre,M.Descripcion Marca,a.Descripcion,ImagenUrl,C.Descripcion from ARTICULOS A, CATEGORIAS C, MARCAS M where C.id = A.IdCategoria and M.Id = A.IdMarca");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenURL = (string)datos.Lector["ImagenUrl"];
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

        }
}
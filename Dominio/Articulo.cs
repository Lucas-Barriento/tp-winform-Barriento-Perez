﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {   
        //Annotations

        public int ID { get; set; }
        
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string ImagenURL { get; set; }
        public double Precio { get; set; }

        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }

       public MARCA Marca { get; set; }
        /* public int IDMarca { get; set; }
         public int IDCategoria { get; set; }
         public float Precio { get; set; }*/
    }
}

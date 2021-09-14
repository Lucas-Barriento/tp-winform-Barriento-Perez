using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenURL { get; set; }

        public Categoria Categoria { get; set; }

        public MARCA Marca { get; set; }
        /* public int IDMarca { get; set; }
         public int IDCategoria { get; set; }
         public float Precio { get; set; }*/
    }
}

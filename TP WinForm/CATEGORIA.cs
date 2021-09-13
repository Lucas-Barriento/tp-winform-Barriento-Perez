using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_WinForm
{
    class CATEGORIA
    {
        public int ID { get; set; }
        public string CATdescripcion { get; set; }

        public override string ToString()
        {
            return CATdescripcion;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_WinForm
{
    class MARCA
    {
        public int id { get; set; }
        public string marca { get; set; }

        public override string ToString()
        {
            return marca;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2
{
    class Perfil
    {
        public int perfil_id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}

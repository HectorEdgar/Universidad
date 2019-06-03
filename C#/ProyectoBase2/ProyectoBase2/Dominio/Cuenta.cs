using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2
{
    class Cuenta
    {
        public int cuenta_id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string correoelectronico { get; set; }
        public string estado { get; set; }
        public Persona persona { get; set; }
        public Perfil  perfil { get; set; }

    }
}

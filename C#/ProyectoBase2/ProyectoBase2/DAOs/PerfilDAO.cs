using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2
{
    interface PerfilDAO
    {
        Perfil obtenerPerfil(String perfil);
        List<Perfil> obtenerPerfiles();
    }
}

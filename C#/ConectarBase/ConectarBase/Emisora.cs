using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarBase
{
    interface Emisora
    {
        List<Inversion> obtenerInversiones();
    }
}

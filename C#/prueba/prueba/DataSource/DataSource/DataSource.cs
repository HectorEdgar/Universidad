using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09May16_Lazaro
{
    interface DataSource
    {
        Object EjecutarConsulta(String consulta);
        int EjecutarActualizacion(String consulta);
    }
}

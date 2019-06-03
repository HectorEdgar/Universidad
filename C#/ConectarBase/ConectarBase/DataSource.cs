using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarBase
{
    interface DataSource
    {
        MySqlDataReader EjecutarConsulta(String consulta);
        int EjecutarActualizacion(String consulta);

    }
}

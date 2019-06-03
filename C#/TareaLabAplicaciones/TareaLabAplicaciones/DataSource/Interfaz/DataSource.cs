using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaLabAplicaciones.DataSource
{
    
    interface DataSource
    {
        //metodos abstractos que se ocuparan para hacer consultas y actualizaciones a una base de datos
        SqlDataReader ejecutarConsulta(String consulta);
        int ejecutarActualizacion(String actualizacion);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConectarBase
{
    class DataSourceImpl : DataSource
    {
        private MySqlConnection conex;
        private String protocolo;
        private MySqlCommand instruccion;
        private MySqlDataReader reader;
       
        
        public DataSourceImpl()
        {
            conex = new MySqlConnection();
            protocolo = "Server=localhost; Database=finanzas; Uid=root; Pwd=MATIAS96edgar";
            conex.ConnectionString = protocolo;
            conex.Open();
            instruccion = conex.CreateCommand();
            
        }

        public MySqlDataReader EjecutarConsulta(string consulta)
        {
            try
            {
                instruccion.CommandText = consulta;
                reader = instruccion.ExecuteReader();
                
 
                //reader.Dispose();
                //conex.Dispose();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error...");
                Console.WriteLine(ex.ToString());
            }
           
            return reader;
        }

        public int EjecutarActualizacion(string consulta)
        {
            instruccion.CommandText = consulta;
            return instruccion.ExecuteNonQuery(); ;

        }
    }
}

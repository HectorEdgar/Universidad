using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventariosDT
{
    class DataSourceImpl : DataSource
    {
        //precio historico, cuenta
        private MySqlConnection conex;
        private String protocolo;
        MySqlCommand instruccion;
        MySqlDataReader reader;
        public DataSourceImpl()
        {
            conex = new MySqlConnection();
            protocolo = "Server=172.16.22.34; Database=emisora; Uid=mysql; Pwd=admin";
            //conex = new MySqlConnection();
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
                Console.WriteLine("Error..."+ex.Message);
            }
           
            return reader;
        }

        public int EjecutarActualizacion(string consulta)
        {
            int numeroFilasAfectadas = 0;

            try
            {
                instruccion.CommandText = consulta;
                numeroFilasAfectadas= instruccion.ExecuteNonQuery();
            } catch (MySqlException ex)
            {
                Console.WriteLine("Error..."+ex.Message);
            }



            return numeroFilasAfectadas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _09May16_Lazaro
{
    class DataSourceImpl : DataSource
    {
        private MySqlConnection conex;
        private string protocolo;
        MySqlCommand instruccion;
        MySqlDataReader reader;

        public DataSourceImpl()
        {
            conex = new MySqlConnection();
            protocolo = "Server=localhost; Database=PuntoDeVenta; Uid=adminPV; Pwd=admin";
            conex.ConnectionString = protocolo;
            garconex.Open();
            instruccion = conex.CreateCommand();
        }

        public Object EjecutarConsulta(string consulta)
        {
            try
            {
                instruccion.CommandText = consulta;
                reader = instruccion.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error..." + ex.Message + "\n" + consulta);
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
                MessageBox.Show("Error..." + ex.Message + "\n" + consulta);
            }

            return numeroFilasAfectadas;
        }
    }
}

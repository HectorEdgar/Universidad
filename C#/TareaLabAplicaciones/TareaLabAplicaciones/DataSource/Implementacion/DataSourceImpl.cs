using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaLabAplicaciones.DataSource
{
    public class DataSourceImpl : DataSource
    {
        //Cadena de conexion a una base de datos sqlserver
        private string protocolo = "Data Source=localhost;Initial Catalog=mventas;Integrated Security=True";
        SqlCommand instruccion = null;
        SqlConnection conex = null;
        SqlDataReader reader = null;

        public DataSourceImpl()
        {
            try
            {
                //Se instancian los objetos y se abre una conexion con la cadena de conexion
                conex = new SqlConnection();
                conex.ConnectionString = protocolo;
                conex.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.StackTrace);

            }
        }
        //Ejecuta una consulta a la BD
        public SqlDataReader ejecutarConsulta(string consulta)
        {
            try
            {
                //Se crea un objeto SqlCommand con la conexion(conex) que se abrio anteriormente 
                instruccion = conex.CreateCommand();
                //se asigna la consulta ala propiedad CommandText
                instruccion.CommandText = consulta;
                //se asigna al objeto SqlDataReader la informacion obtenida de la consulta
                reader = instruccion.ExecuteReader();

            }
            catch (Exception e)
            {
                //Si se genera un error se mostrara un mensaje de texto
                Console.WriteLine(e.StackTrace);
            }
            //la funcion devuelve un objeto de tipo SqlDataReader
            return reader;
        }


        //ejecuta una actualizacion a la BD 
        public int ejecutarActualizacion(string actualizacion)
        {
            int numFilasAfectadas = 0;
            try
            {
                //Se crea un objeto SqlCommand con la conexion(conex) que se abrio anteriormente 
                instruccion = conex.CreateCommand();
                //se asigna la consulta ala propiedad CommandText
                instruccion.CommandText = actualizacion;
                //se  hace la actualizacion y se asigna el numero de filas afectadas ala variable numFilasAfectadas 
                numFilasAfectadas = instruccion.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Si se genera un error se mostrara un mensaje de texto
                Console.WriteLine(e.StackTrace);
            }
            //la funcion devuelve el numero de filas afectadas
            return numFilasAfectadas;
        }

    }
}

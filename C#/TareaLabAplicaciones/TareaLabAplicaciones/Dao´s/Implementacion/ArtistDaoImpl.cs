using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaLabAplicaciones.Dao_s.Implementacion
{
    class ArtistDaoImpl : ArtistDao
    {
        private String query;

       
        //Este metodo elimina un Artista de la BD
        public int deleteArtist(string name)
        {
            // se crea el objeto de tipo DataSourceImpl
            DataSource.DataSource ds = new DataSource.DataSourceImpl();
            
            query = "DELETE FROM  artist where artName='" + name + "';";

            //se envia el query  y regresa el numero de filas afectadas
            return ds.ejecutarActualizacion(query);
        }
        //Obtiene todos los datos de la tabla Artist
        public List<Artist> getArtists()
        {
            // se crea el objeto de tipo DataSourceImpl
            DataSource.DataSource ds = new DataSource.DataSourceImpl();
            //Se crea una lista de Artist para almacenar los datos de la consulta
            List<Artist> artists = new List<Artist>();
            query = "SELECT * FROM ARTIST";
            try
            {
                //se crea un SqlDataReader y lo igualamos con la consulta realizada por el DataSource
                SqlDataReader reader = ds.ejecutarConsulta(query);
                //Mientras halla datos se ejecutara el while
                while (reader.Read())
                {
                    //Se crea un objeto de tipo Artist en cada iteracion y se asignan los valores de acuerdo con la informacion del reader
                    Artist a = new Artist();
                    a.Name = "" + reader["artName"];
                    a.Company.Name = "" + reader["company"];
                    a.Sales = "" + reader["sales"];

                    //Se agrega el objeto de tipo Artist a la lista 
                    artists.Add(a);
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Error "+e.StackTrace);
            }
            
            //se  retorna la lista
            return artists;
        }

        public Artist searchArtist(Company company)
        {
            // se crea el objeto de tipo DataSourceImpl
            DataSource.DataSource ds = new DataSource.DataSourceImpl();

            query = "SELECT * FROM ARTIST WHERE company LIKE '%"+company.Name+"%';";
            //se crea un SqlDataReader y lo igualamos con la consulta realizada por el DataSource
            SqlDataReader reader = ds.ejecutarConsulta(query);
            // se crea el objeto que devolvera la funcion
             Artist a = new Artist();
            //Si hay datos en el reader entra al if
            if (reader.Read())
            {
                //Se asignan los datos al objeto de tipo Artist
                a.Name = "" + reader["artName"];
                a.Company.Name = "" + reader["company"];
                a.Sales = "" + reader["sales"];
            }

            //retorna el objeto de tipo Artist
            return a;

        }

        //busca un Artista por el nombre  y regresa un objeto de tipo Artist
        public Artist searchArtist(string name)
        {
            // se crea el objeto de tipo DataSourceImpl
            DataSource.DataSource ds = new DataSource.DataSourceImpl();

            query = "SELECT * FROM ARTIST WHERE artName LIKE '%" + name + "%';";
            //se crea un SqlDataReader y lo igualamos con la consulta realizada por el DataSource
            SqlDataReader reader = ds.ejecutarConsulta(query);
            //se crea el objeto que devolvera la funcion
            Artist a = new Artist();
            //Si hay datos en el reader entra al if
            if (reader.Read())
            {
                //Se asignan los datos al objeto de tipo Artist
                a.Name = "" + reader["artName"];
                a.Company.Name = "" + reader["company"];
                a.Sales = "" + reader["sales"];
            }
           
            
            //retorna el objeto de tipo Artist
            return a;
        }

       
        //actualiza la compañia y kas ventas de un artista
        public int updateArtist(String name, String company, string sales)
        {
            // se crea el objeto de tipo DataSourceImpl
            DataSource.DataSource ds = new DataSource.DataSourceImpl();

            query = "UPDATE  artist SET company='"+ company + "', sales='"+sales+"' where artName='"+name+"';";
            //se envia el query de la actualizacion  y regresa el numero de filas afectadas
            return ds.ejecutarActualizacion(query);
        }

        //busca un Artista por nombre y compañia
        public Artist searchArtist(string name, Company company)
        {
            // se crea el objeto de tipo DataSourceImpl
            DataSource.DataSource ds = new DataSource.DataSourceImpl();

            query = "SELECT * FROM ARTIST WHERE artName = '" + name + "' AND company = '"+ company.Name+"';";
            //se crea un SqlDataReader y lo igualamos con la consulta realizada por el DataSource
            SqlDataReader reader = ds.ejecutarConsulta(query);
            //se crea el objeto que devolvera la funcion
            Artist a = new Artist();
            //Si hay datos en el reader entra al if
            if (reader.Read())
            {
                //Se asignan los datos al objeto de tipo Artist
                a.Name = "" + reader["artName"];
                a.Company.Name = "" + reader["company"];
                a.Sales = "" + reader["sales"];
            }

            //retorna el objeto de tipo Artist

            return a;
        }

        //Agregar un Artista
        public int addArtist(string name, String company, string sales)
        {
            // se crea el objeto de tipo DataSourceImpl
            DataSource.DataSource ds = new DataSource.DataSourceImpl();

            query = "insert into artist (artName,company,sales) values ('" + name + "','" + company + "','" + sales + "');";
            //se envia el query de la actualizacion  y regresa el numero de filas afectadas
            return ds.ejecutarActualizacion(query);
        }

       
        public string getQuery()
        {
            String aux = query;
            query = "";
            return aux;
        }

        public string Query
        {
            get
            {
                return query;
            }

            set
            {
                query = value;
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2
{
    class PerfilDAOImpl : PerfilDAO
    {
        private MySqlDataReader reader;

        public Perfil obtenerPerfil(string perfil)
        {
            DataSource ds = new DataSourceImpl();

            String consulta = "SELECT * FROM Perfil WHERE nombre = '" + perfil +"';";
            reader = (MySqlDataReader)ds.EjecutarConsulta(consulta);

            Perfil p = new Perfil();

            reader.Read();

            p.descripcion = Convert.ToString(reader["descripcion"]);
            p.nombre = Convert.ToString(reader["nombre"]);
            p.estado = Convert.ToString(reader["estado"]);
            p.perfil_id = Convert.ToInt32(reader["perfil_id"]);
            
            return p;
        }

        public List<Perfil> obtenerPerfiles()
        {
            DataSource ds = new DataSourceImpl();

            string consulta = "SELECT * FROM perfil;";
            reader = (MySqlDataReader)ds.EjecutarConsulta(consulta);

            List<Perfil> l = new List<Perfil>();

            Perfil p;

            while(reader.Read())
            {
                p = new Perfil();

                p.descripcion = Convert.ToString(reader["descripcion"]);
                p.nombre = Convert.ToString(reader["nombre"]);
                p.estado = Convert.ToString(reader["estado"]);
                p.perfil_id = Convert.ToInt32(reader["perfil_id"]);

                l.Add(p);
            }

            return l;
        }
    }
}

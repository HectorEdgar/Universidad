using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosDT
{
    class MaterialDaoImpl : MaterialDao
    {
        private MySqlDataReader reader;
        public int actualizarMateriales(Material material)
        {
            DataSource ds = new DataSourceImpl();
            String consulta = "update material set " +
                "Mate_Nombre='" + material.Nombre +
                "',Mate_Modelo='" + material.Modelo +
                "', Mate_Marca='" + material.Marca +
                "', Mate_FechaAdquisicion='" + material.FechaDeAdquisicion +
                "',Mate_disponible=" + material.Disponible +
                ",Mate_Eliminado=" + material.Eliminado +
                " where Mate_Codigo=" + material.IdMaterial + ";";
            return ds.EjecutarActualizacion(consulta);
        }

        public int AgregarMaterial(Material material)
        {
            DataSource ds = new DataSourceImpl();
            String consulta = "INSERT INTO MATERIALES(Mate_Codigo,Mate_Nombre,Mate_Modelo,Mate_Marca,Mate_FechaAdquisicion,Mate_disponible,Mate_Eliminado) values" +
               "(" + material.IdMaterial +
               ",'" + material.Nombre +
               "','" + material.Modelo +
               "','" + material.Marca +
               "','" + material.FechaDeAdquisicion +
               "'," + material.Disponible +
               "," + material.Eliminado + ") ";
            return ds.EjecutarActualizacion(consulta);
        }

        public int EliminarMaterial(int id)
        {
            DataSource ds = new DataSourceImpl();
            String consulta = "delete from material where Mate_Codigo=" + id + ";";
            return ds.EjecutarActualizacion(consulta);
        }

        public Material obtenerMaterial(int id)
        {

            DataSource ds = new DataSourceImpl();
            reader = ds.EjecutarConsulta("SELECT * FROM material WHERE Mate_Codigo = " + id + ";");

            reader.Read();

            Material m = new Material();

            m.IdMaterial = Convert.ToInt16(reader["Mate_Codigo"]);
            m.Nombre = "" + reader["Mate_Nombre"];
            m.Modelo = "" + reader["Mate_Modelo"];
            m.Marca = "" + reader["Mate_Marca"];
            m.FechaDeAdquisicion = "" + reader["Mate_FechaAdquisicion"];
            m.Disponible = Convert.ToBoolean(reader["Mate_disponible"]);
            m.Eliminado = Convert.ToBoolean(reader["Mate_Eliminado"]);



            return m;
        }

        public List<Material> obtenerMateriales()
        {
            DataSource ds = new DataSourceImpl();
            reader = ds.EjecutarConsulta("SELECT * FROM material");
            List<Material> materiales = new List<Material>();
            while (reader.Read())
            {
                Material m = new Material();

                m.IdMaterial = Convert.ToInt16(reader["Mate_Codigo"]);
                m.Nombre = "" + reader["Mate_Nombre"];
                m.Modelo = "" + reader["Mate_Modelo"];
                m.Marca = "" + reader["Mate_Marca"];
                m.FechaDeAdquisicion = "" + reader["Mate_FechaAdquisicion"];
                m.Disponible = Convert.ToBoolean(reader["Mate_disponible"]);
                m.Eliminado = Convert.ToBoolean(reader["Mate_Eliminado"]);

                materiales.Add(m);
            }
            return materiales;
        }

        public List<Material> obtenerMateriales(string nombre)
        {
            DataSource ds = new DataSourceImpl();
            reader = ds.EjecutarConsulta("SELECT * FROM material WHERE MATERIAL.Mate_Nombre LIKE '%" + nombre + "';");
            List<Material> materiales = new List<Material>();
            while (reader.Read())
            {
                Material m = new Material();

                m.IdMaterial = Convert.ToInt16(reader["Mate_Codigo"]);
                m.Nombre = "" + reader["Mate_Nombre"];
                m.Modelo = "" + reader["Mate_Modelo"];
                m.Marca = "" + reader["Mate_Marca"];
                m.FechaDeAdquisicion = "" + reader["Mate_FechaAdquisicion"];
                m.Disponible = Convert.ToBoolean(reader["Mate_disponible"]);
                m.Eliminado = Convert.ToBoolean(reader["Mate_Eliminado"]);

                materiales.Add(m);
            }
            return materiales;
        }
    }
}

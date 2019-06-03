using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarBase
{
    class EmisoraImpl : Emisora
    {
        private MySqlDataReader reader;
 

        public List<Inversion> obtenerInversiones()
        {
            
            DataSource ds = new DataSourceImpl();
            reader= ds.Consulta("SELECT * FROM Inversion");

            List<Inversion> inversiones = new List<Inversion>();

            while (reader.Read())
            {
                
                Inversion i = new Inversion();
                i.Fecha =""+reader["Fecha"];
                i.Precio = Convert.ToDouble(reader["Precio"]);
                i.Maxima= Convert.ToDouble(reader["Maxima"]);
                i.Baja= Convert.ToDouble(reader["Baja"]);
                i.Cierre= Convert.ToDouble(reader["Cierre"]);
                i.Volumen= Convert.ToDouble(reader["Volumen"]);
                i.CierreAjustado= Convert.ToDouble(reader["CierreAjustado"]);
                //Console.WriteLine(i.toString());
                inversiones.Add(i);

            }

            return inversiones;

        }

        private double[] CalcularDesviacionEstandar(List<Inversion> inversiones)
        {
            

            return null;



        }
    }
}

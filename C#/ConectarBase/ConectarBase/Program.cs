using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ConectarBase
{
    class Program
    {


        static void Main(string[] args)
        {

            //try
            //{
            //    MySqlConnection conex = new MySqlConnection();
            //    String protocolo = "Server=localhost; Database=sakila; Uid=root; Pwd=MATIAS96edgar";
            //    conex.ConnectionString = protocolo;
            //    conex.Open();

            //    MySqlCommand instruccion = conex.CreateCommand();
            //    instruccion.CommandText = "SELECT * FROM city";
            //    MySqlDataReader reader = instruccion.ExecuteReader();

            //    while(reader.Read()){
            //        Console.WriteLine("ID: {0},City: {1}",reader["city_id"], reader["city"]);

            //    }
            //    reader.Dispose();
            //    conex.Dispose();

            //} 
            //catch(MySqlException ex)
            //{
            //    Console.WriteLine("Error...");
            //}
            //Console.ReadKey();

            //DataSource data = new DataSourceImpl();
            //MySqlDataReader d= data.Consulta("SELECT * FROM city");

            //while (d.Read())
            //{
            //    Console.WriteLine("ID: {0},City: {1}", d["city_id"], d["city"]);
            //}
            //Console.ReadKey();
            //double sumatoriaPrecio = 0;
            //double sumatoriaMaxima = 0;
            //double sumatoriaBaja = 0;
            //double sumatoriaCierre = 0;
            //double sumatoriaVolumen = 0;
            //double sumatoriaCierreAjuste = 0;

            double PromedioPrecio = 0;
            double PromedioMaxima = 0;
            double PromedioBaja = 0;
            double PromedioCierre = 0;
            double PromedioVolumen = 0;
            double PromedioCierreAjuste = 0;

            double varianzaPrecio = 0;
            double varianzaMaxima = 0;
            double varianzaBaja = 0;
            double varianzaCierre = 0;
            double varianzaVolumen = 0;
            double varianzaCierreAjuste = 0;

            double desviacionEstandarPrecio = 0;
            double desviacionEstandarMaxima = 0;
            double desviacionEstandarBaja = 0;
            double desviacionEstandarCierre = 0;
            double desviacionEstandarVolumen = 0;
            double desviacionEstandarCierreAjuste = 0;
            int numDatos = 0;
            Emisora emisora = new EmisoraImpl();
            List<Inversion> inversiones = emisora.obtenerInversiones();



            foreach (Inversion inversion in inversiones)
            {

                PromedioPrecio = PromedioPrecio + inversion.Precio;
                PromedioMaxima = PromedioMaxima + inversion.Maxima;
                PromedioBaja = PromedioBaja + inversion.Baja;
                PromedioCierre = PromedioCierre + inversion.Cierre;
                PromedioCierreAjuste = PromedioCierreAjuste + inversion.CierreAjustado;
                PromedioVolumen = PromedioVolumen + inversion.Volumen;
                numDatos++;
            }

            PromedioPrecio = PromedioPrecio / numDatos;
            PromedioMaxima = PromedioMaxima / numDatos;
            PromedioBaja = PromedioBaja / numDatos;
            PromedioCierre = PromedioCierre / numDatos;
            PromedioCierreAjuste = PromedioCierreAjuste / numDatos;
            PromedioVolumen = PromedioVolumen / numDatos;
            foreach (Inversion inversion in inversiones)
            {
                varianzaPrecio = varianzaPrecio + Math.Pow((inversion.Precio - PromedioPrecio), 2);
                varianzaMaxima = varianzaMaxima + Math.Pow((inversion.Maxima - PromedioMaxima), 2);
                varianzaBaja = varianzaBaja + Math.Pow((inversion.Baja - PromedioBaja), 2);
                varianzaCierre = varianzaCierre + Math.Pow((inversion.Cierre - PromedioCierre), 2);
                varianzaCierreAjuste = varianzaCierreAjuste + Math.Pow((inversion.CierreAjustado - PromedioCierreAjuste), 2);
                varianzaVolumen = varianzaVolumen + Math.Pow((inversion.Volumen - PromedioVolumen), 2);
            }
            varianzaPrecio = varianzaPrecio / numDatos;
            varianzaMaxima = varianzaMaxima / numDatos;
            varianzaBaja = varianzaBaja / numDatos;
            varianzaCierre = varianzaCierre / numDatos;
            varianzaCierreAjuste = varianzaCierreAjuste / numDatos;
            varianzaVolumen = varianzaVolumen / numDatos;

            desviacionEstandarPrecio = Math.Sqrt(varianzaPrecio);
            desviacionEstandarMaxima = Math.Sqrt(varianzaMaxima);
            desviacionEstandarBaja = Math.Sqrt(varianzaBaja);
            desviacionEstandarCierre = Math.Sqrt(varianzaCierre);
            desviacionEstandarCierreAjuste = Math.Sqrt(varianzaCierreAjuste);
            desviacionEstandarVolumen = Math.Sqrt(varianzaVolumen);

            double[] desviacionesEstandar = new double[6];
            desviacionesEstandar[0] = desviacionEstandarPrecio;
            desviacionesEstandar[1] = desviacionEstandarMaxima;
            desviacionesEstandar[2] = desviacionEstandarBaja;
            desviacionesEstandar[3] = desviacionEstandarCierre;
            desviacionesEstandar[4] = desviacionEstandarVolumen;
            desviacionesEstandar[5] = desviacionEstandarCierreAjuste;

            Console.WriteLine("La desviacion estandar de Precio es: " + desviacionesEstandar[0]);
            Console.WriteLine("La desviacion estandar de Maxima es: " + desviacionesEstandar[1]);
            Console.WriteLine("La desviacion estandar de Baja es: " + desviacionesEstandar[2]);
            Console.WriteLine("La desviacion estandar de Cierre es: " + desviacionesEstandar[3]);
            Console.WriteLine("La desviacion estandar de Volumen es: " + desviacionesEstandar[4]);
            Console.WriteLine("La desviacion estandar de CierreAjustado es: " + desviacionesEstandar[5]);
            Console.ReadKey();


        }
    }
}

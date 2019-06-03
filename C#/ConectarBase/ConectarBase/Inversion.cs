using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectarBase
{

    class Inversion
    {
        private String fecha;
        private double precio;
        private double maxima;
        private double baja;
        private double cierre;
        private double volumen;
        private double cierreAjustado;

        public Inversion(string fecha, double precio, double maxima, double baja, double cierre, double volumen, double cierreAjustado)
        {
            this.fecha = fecha;
            this.precio = precio;
            this.maxima = maxima;
            this.baja = baja;
            this.cierre = cierre;
            this.volumen = volumen;
            this.cierreAjustado = cierreAjustado;
        }
        public Inversion()
        {
            this.fecha = "";
            this.precio = 0;
            this.maxima = 0;
            this.baja = 0;
            this.cierre = 0;
            this.volumen = 0;
            this.cierreAjustado = 0;
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public double Maxima
        {
            get
            {
                return maxima;
            }

            set
            {
                maxima = value;
            }
        }

        public double Baja
        {
            get
            {
                return baja;
            }

            set
            {
                baja = value;
            }
        }

        public double Cierre
        {
            get
            {
                return cierre;
            }

            set
            {
                cierre = value;
            }
        }

        public double Volumen
        {
            get
            {
                return volumen;
            }

            set
            {
                volumen = value;
            }
        }

        public double CierreAjustado
        {
            get
            {
                return cierreAjustado;
            }

            set
            {
                cierreAjustado = value;
            }
        }


        public String toString()
        {
            return (""+this.fecha+" "+this.precio+" "+this.maxima + " " +this.baja+" " +this.cierre + " " +this.volumen + " " +this.cierreAjustado);
        }
    }

    
}

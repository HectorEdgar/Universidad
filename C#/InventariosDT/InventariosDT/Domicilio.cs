using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosDT
{
    class Domicilio
    {
        private int idDomicilio;
        private String calle;
        private String colonia;
        private String municiopio;
        private String codigoPostal;
        private bool estado;

        public Domicilio()
        {
            this.idDomicilio = 0;
            this.calle = "";
            this.colonia = "";
            this.municiopio = "";
            this.CodigoPostal = "";
            this.estado = false;
        }

        public int IdDomicilio
        {
            get
            {
                return idDomicilio;
            }

            set
            {
                idDomicilio = value;
            }
        }

        public string Calle
        {
            get
            {
                return calle;
            }

            set
            {
                calle = value;
            }
        }

        public string Colonia
        {
            get
            {
                return colonia;
            }

            set
            {
                colonia = value;
            }
        }

        public string Municiopio
        {
            get
            {
                return municiopio;
            }

            set
            {
                municiopio = value;
            }
        }

        public string CodigoPostal
        {
            get
            {
                return codigoPostal;
            }

            set
            {
                codigoPostal = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}

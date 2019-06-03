using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosDT
{
    class Solicitante
    {
        private int idSolicitante;
        private List<Domicilio> domicilios;
        private String nombre;
        private String fechaNacimiento;
        private String sexo;
        private int numPedidos;
        private bool estado;

        public Solicitante()
        {
            this.idSolicitante = 0;
            this.domicilios = null;
            this.nombre = "";
            this.fechaNacimiento = "";
            this.sexo = "";
            this.numPedidos = 0;
            this.estado = false;

        }


        public int IdSolicitante
        {
            get
            {
                return idSolicitante;
            }

            set
            {
                idSolicitante = value;
            }
        }

        internal List<Domicilio> Domicilios
        {
            get
            {
                return domicilios;
            }

            set
            {
                domicilios = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public int NumPedidos
        {
            get
            {
                return numPedidos;
            }

            set
            {
                numPedidos = value;
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

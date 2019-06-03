using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2.Dominio
{
    class Hotel
    {
        private int idHotel;
        private String nombre;
        private String direccion;
        private String telefono;
        private String añoContruccion;
        private Categoria categoria;
        List<Habitacion> habitaciones;

        public int IdHotel
        {
            get
            {
                return idHotel;
            }

            set
            {
                idHotel = value;
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

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string AñoContruccion
        {
            get
            {
                return añoContruccion;
            }

            set
            {
                añoContruccion = value;
            }
        }

        internal Categoria Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        internal List<Habitacion> Habitaciones
        {
            get
            {
                return habitaciones;
            }

            set
            {
                habitaciones = value;
            }
        }
    }
}

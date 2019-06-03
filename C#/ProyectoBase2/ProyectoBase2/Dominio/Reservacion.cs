using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2.Dominio
{
    class Reservacion
    {
        private int idReservacion;
        private String nombre;
        private String direccion;
        private String telefono;
        private float precioReserva;
        private String fechaInicio;
        private String fechaFinal;
        private Hotel hotel;
        private String agenciaEncargada;

        public int IdReservacion
        {
            get
            {
                return idReservacion;
            }

            set
            {
                idReservacion = value;
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

        public float PrecioReserva
        {
            get
            {
                return precioReserva;
            }

            set
            {
                precioReserva = value;
            }
        }

        public string FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public string FechaFinal
        {
            get
            {
                return fechaFinal;
            }

            set
            {
                fechaFinal = value;
            }
        }

        internal Hotel Hotel
        {
            get
            {
                return hotel;
            }

            set
            {
                hotel = value;
            }
        }

        public string AgenciaEncargada
        {
            get
            {
                return agenciaEncargada;
            }

            set
            {
                agenciaEncargada = value;
            }
        }
    }
}

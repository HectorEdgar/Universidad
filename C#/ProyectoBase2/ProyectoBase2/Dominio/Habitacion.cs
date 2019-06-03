using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2.Dominio
{
    class Habitacion
    {
        private int idHabitacion;
        private String tipoHabitacion;
        private bool disponible;

        public int IdHabitacion
        {
            get
            {
                return idHabitacion;
            }

            set
            {
                idHabitacion = value;
            }
        }

        public string TipoHabitacion
        {
            get
            {
                return tipoHabitacion;
            }

            set
            {
                tipoHabitacion = value;
            }
        }

        public bool Disponible
        {
            get
            {
                return disponible;
            }

            set
            {
                disponible = value;
            }
        }
    }
}

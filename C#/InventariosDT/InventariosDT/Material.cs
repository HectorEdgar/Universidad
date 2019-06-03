using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosDT
{
    class Material
    {
        private int idMaterial;
        private String nombre;
        private String modelo;
        private String marca;
        
        private String fechaDeAdquisicion;
        
       

        private bool disponible;
        private bool eliminado;

        public int IdMaterial
        {
            get
            {
                return idMaterial;
            }

            set
            {
                idMaterial = value;
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

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string FechaDeAdquisicion
        {
            get
            {
                return fechaDeAdquisicion;
            }

            set
            {
                fechaDeAdquisicion = value;
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

        public bool Eliminado
        {
            get
            {
                return eliminado;
            }

            set
            {
                eliminado = value;
            }
        }

        public Material()
        {
            this.IdMaterial = 0;
            this.Modelo = "";
            this.Marca = "";
            this.Nombre = "";
            this.Eliminado = false;
            this.Disponible = false;
            
        }



    }
}

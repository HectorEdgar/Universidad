using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosDT
{
    class Pedido
    {
        private Material material;
        private Solicitante solicitante;
        private String fechaPedido;
        private String fechaLimite;
        private String fecahEntrega;
        private bool estado = false;
        public Pedido()
        {
            this.material = null;
            this.solicitante = null;
            this.FechaPedido = "";
            this.fechaLimite = "";
            this.fecahEntrega = "";
            this.estado = false;
        }
        internal Material Material
        {
            get
            {
                return material;
            }

            set
            {
                material = value;
            }
        }

        internal Solicitante Solicitante
        {
            get
            {
                return solicitante;
            }

            set
            {
                solicitante = value;
            }
        }

        public string FechaPedido
        {
            get
            {
                return fechaPedido;
            }

            set
            {
                fechaPedido = value;
            }
        }

        public string FechaLimite
        {
            get
            {
                return fechaLimite;
            }

            set
            {
                fechaLimite = value;
            }
        }

        public string FecahEntrega
        {
            get
            {
                return fecahEntrega;
            }

            set
            {
                fecahEntrega = value;
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

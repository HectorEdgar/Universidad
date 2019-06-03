using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2
{
    class Controller
    {
        private CuentaDAO cuentaDAO;





        public Boolean validarCuenta(String usuario, String contrasena)
        {
            cuentaDAO = new CuentaDaoImpl();
            Cuenta cuenta = cuentaDAO.obtenerCuenta(usuario, contrasena);

            if(cuenta == null)
            {
                return false;
            } else
            {
                return true;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2
{
    interface CuentaDAO
    {
        Cuenta obtenerCuenta(string usuario, string contrasena);
        List<Cuenta> obtenerCuentas(string filtro);
        List<Cuenta> obtenerCuentas();

        int registrarCuenta(Cuenta c);
        int eliminarCuenta(Cuenta c);
        int actualizarCuenta(Cuenta c);
    }
}

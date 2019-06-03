using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosDT
{
    interface MaterialDao
    {
        List<Material> obtenerMateriales();
        List<Material> obtenerMateriales(String nombre);
        Material obtenerMaterial(int id);

        int AgregarMaterial(Material material);
        int EliminarMaterial(int id);
        int actualizarMateriales(Material material);
    }
}

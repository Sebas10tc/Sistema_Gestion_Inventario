using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class NDetalleMaterial
    {
        DDetalleMaterialProducto dDetalleMaterialProducto = new DDetalleMaterialProducto();
        public String Asignar(DetalleMaterialProducto detalleMaterialProducto, int id_Material, int id_Producto)
        {
            return dDetalleMaterialProducto.Asignar(detalleMaterialProducto, id_Material, id_Producto);
        }

        public String Desasignar(int id_DetalleMaterialProducto)
        {
            return dDetalleMaterialProducto.Desasignar(id_DetalleMaterialProducto);
        }

        public String Modificar(DetalleMaterialProducto detalleMaterialProducto, int Id_Producto, int Id_Material)
        {
            return dDetalleMaterialProducto.Modificar(detalleMaterialProducto, Id_Producto, Id_Material);
        }

        public List<DetalleMaterialProducto> ListarTodo(int id_Producto)
        {
            return dDetalleMaterialProducto.ListarTodo(id_Producto);
        }
    }
}

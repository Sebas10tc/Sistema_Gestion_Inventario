using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDetallePedido
    {
        private DDetallePedido dDetallePedido = new DDetallePedido();
        public String Registrar(DetallePedido detallePedido, int Id_Pedido, int Id_Producto)
        {
            return dDetallePedido.Registrar(detallePedido, Id_Pedido, Id_Producto);
        }

        public String Modificar(DetallePedido detallePedido)
        {
            return dDetallePedido.Modificar(detallePedido);
        }

        public String Eliminar(int Id_detalle)
        {
            return dDetallePedido.Eliminar(Id_detalle);
        }

        public List<DetallePedido> ListarTodo(int Id_pedido)
        {
            return dDetallePedido.ListarTodo(Id_pedido);
        }
        public String ObtenerNombre(int ID_Usuario)
        {
            return dDetallePedido.ObtenerNombre(ID_Usuario);
        }

        public decimal ObtenerTotal(int ID_Pedido)
        {
            return dDetallePedido.ObtenerTotal(ID_Pedido);
        }
        public List<Producto> ListarMasVendidos()
        {
            return dDetallePedido.ListarMasVendidos();
        }

    }
}

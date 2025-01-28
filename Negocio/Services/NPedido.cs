using Datos;
using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class NPedido
    {
        private DPedido dPedido = new DPedido();
        public String Registrar(Pedido pedido)
        {
            return dPedido.Registrar(pedido);
        }

        public String Modificar(Pedido pedido)
        {
            return dPedido.Modificar(pedido);

        }

        public String Eliminar(int id_pedido)
        {
            return dPedido.Eliminar(id_pedido);

        }

        public List<Pedido> ListarTodo(int Id_Cliente)
        {
            return dPedido.ListarTodo(Id_Cliente);

        }



        public String ObtenerNombre(int ID_Usuario)
        {
            return dPedido.ObtenerNombre(ID_Usuario);

        }

        public void ActualizarPedidos(Pedido pedido)
        {
            dPedido.ActualizarPedidos(pedido);
        }
    }
}

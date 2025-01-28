using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class DPedido
    {
        private DUsuario dUsuario = new DUsuario();
        private DDetallePedido dDetallePedido = new DDetallePedido();
        public String Registrar(Pedido pedido)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Pedido.Add(pedido);
                    context.SaveChanges();
                }
                return "Pedido agregado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public String Modificar(Pedido pedido)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Pedido pedidoTemp = context.Pedido.Find(pedido.id_pedido);
                    pedidoTemp.id_cliente = pedido.id_cliente;
                    pedidoTemp.descripcion = pedido.descripcion;
                    pedidoTemp.id_metodoPago = pedido.id_metodoPago;
                    pedidoTemp.updatedBy = pedido.updatedBy;
                    pedidoTemp.updateTime = pedido.updateTime;
                    context.SaveChanges();
                }
                return "Pedido modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void ActualizarPedidos(Pedido pedido)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Pedido pedidoTemp = context.Pedido.Find(pedido.id_pedido);
                    pedidoTemp.id_pedido = pedido.id_pedido;
                    pedidoTemp.total = pedido.total;
                    pedidoTemp.updatedBy = pedido.updatedBy;
                    pedidoTemp.updateTime = pedido.updateTime;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }


        public String Eliminar(int id_pedido)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Pedido pedidoTemp = context.Pedido.Find(id_pedido);
                    context.Pedido.Remove(pedidoTemp);
                    context.SaveChanges();
                }
                return "Pedido eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Pedido> ListarTodo(int Id_Cliente)
        {
            List<Pedido> pedidos = new List<Pedido>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    pedidos = context.Pedido.Where(e=>e.id_cliente==Id_Cliente).ToList();
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                return pedidos;
            }
        }

        public String ObtenerNombre(int ID_Usuario)
        {
            List<Usuario> usuarios = dUsuario.ListarTodo();
            Usuario usuarioEncontrado = usuarios.Find(u => u.id_usuario.Equals(ID_Usuario));

            if (usuarioEncontrado == null)
            {
                return "-";
            }
            else
            {
                return usuarioEncontrado.nombres + " " + usuarioEncontrado.apellidos;
            }
        }
    }
}

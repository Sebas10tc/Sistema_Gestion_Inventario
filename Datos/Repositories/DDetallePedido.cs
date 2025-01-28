using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDetallePedido
    {
        private DUsuario dUsuario = new DUsuario();
        private DCliente dCliente = new DCliente();
        private DProducto dProducto = new DProducto();

        public String Registrar(DetallePedido detallePedido, int Id_Pedido, int Id_Producto)
        {
            List<DetallePedido> detallePedidos = ListarTodo(Id_Pedido);
            bool existe = detallePedidos.Exists(dp => dp.Equals(Id_Producto));

            if (existe == true)
            {
                return "Material ya existente \nIngrese un material/color diferente ";
            }
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.DetallePedido.Add(detallePedido);
                    context.SaveChanges();
                }
                return "Producto del pedido agregado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(DetallePedido detallePedido)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    DetallePedido detalleTemp = context.DetallePedido.Find(detallePedido.id_pedido);
                    detalleTemp.cantidad = detallePedido.cantidad;
                    detalleTemp.precioProducto = detallePedido.precioProducto;
                    detalleTemp.total = detallePedido.total;
                    detalleTemp.updatedBy = detallePedido.updatedBy;
                    detalleTemp.updateTime = detallePedido.updateTime;
                    context.SaveChanges();
                }
                return "Detalle del pedido modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int Id_detalle)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    DetallePedido detalleTemp = context.DetallePedido.Find(Id_detalle);
                    context.DetallePedido.Remove(detalleTemp);
                    context.SaveChanges();
                }
                return "Detalle del pedido eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DetallePedido> ListarTodo(int Id_pedido)
        {
            List<DetallePedido> detallePedidos = new List<DetallePedido>(Id_pedido);
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    detallePedidos = context.DetallePedido.Where(dp=>dp.id_pedido.Equals(Id_pedido)).ToList();
                }
                return detallePedidos;
            }
            catch (Exception ex)
            {
                return detallePedidos;
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

         public decimal ObtenerTotal(int ID_Pedido)
        {
            List<DetallePedido> detallePedidos = ListarTodo(ID_Pedido);
            decimal TotalFinal = 0;

            foreach (DetallePedido detallePedido in detallePedidos)
            {
                TotalFinal = TotalFinal + detallePedido.total;
            }

            return TotalFinal;
        }
        public int SumaPedidosPorID(int ID_Producto)
        {
            List<Cliente> clientesList = new List<Cliente>();
            int sumaFinal = 0;

            try
            {
                using (var context = new FSI_TFEntities())
                {
                    clientesList = context.Cliente.ToList();
                    foreach (Cliente cliente in clientesList)
                    {
                        foreach (Pedido pedido in cliente.Pedido)
                        {
                            foreach (DetallePedido detallePedido in pedido.DetallePedido)
                            {
                                if (detallePedido.id_producto.Equals(ID_Producto))
                                {
                                    sumaFinal += detallePedido.cantidad;
                                }
                            }
                        }
                    }
                }
                return sumaFinal;
            }
            catch (Exception ex)
            {
                return sumaFinal;
            }
        }

        public List<Producto> ListarMasVendidos()
        {
            List<Producto> productos = dProducto.ListarTodo();
            List<Producto> productostemp = new List<Producto>();

            int mayorCantidadProductos = 0;
            int cantidad = 0;

            try
            {


                foreach (Producto producto in productos)
                {
                    cantidad = SumaPedidosPorID(producto.id_producto);

                    if (cantidad > mayorCantidadProductos)
                    {
                        mayorCantidadProductos = cantidad;
                        productostemp.Clear();
                        productostemp.Add(producto);
                    }
                    else if (cantidad == mayorCantidadProductos)
                    {

                        mayorCantidadProductos = cantidad;
                        productostemp.Add(producto);
                    }

                }
                return productostemp;
            }
            catch (Exception ex)
            {
                return productostemp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class DCliente
    {
        private DUsuario dUsuario = new DUsuario();
        public String Registrar(Cliente cliente, int dni)
        {
            List<Cliente> clientes = ListarTodo();
            bool existe = clientes.Exists(u => u.dni.Equals(dni));

            if (existe == true)
            {
                return "Cliente ya existente \nIngrese uno diferente ";
            }
            else
            {
                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        context.Cliente.Add(cliente);
                        context.SaveChanges();
                    }
                    return "Cliente agregado exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public String Modificar(Cliente cliente, int dni)
        {
            List<Cliente> clientes = ListarTodo();
            bool existe = clientes.Exists(u => u.dni.Equals(dni));

            if (existe == true)
            {
                return "Cliente ya existente \nIngrese uno diferente ";
            }
            else
            {
                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        Cliente clienteTemp = context.Cliente.Find(cliente.id_cliente);
                        clienteTemp.dni = cliente.dni;
                        clienteTemp.nombres = cliente.nombres;
                        clienteTemp.apellidos = cliente.apellidos;
                        clienteTemp.telefono = cliente.telefono;
                        clienteTemp.updatedBy = cliente.updatedBy;
                        clienteTemp.updateTime = cliente.updateTime;
                        context.SaveChanges();
                    }
                    return "Cliente modificado exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
                
        }

        public String Eliminar(int id_cliente)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Cliente clienteTemp = context.Cliente.Find(id_cliente);
                    context.Cliente.Remove(clienteTemp);
                    context.SaveChanges();
                }
                return "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Cliente> ListarTodo()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }

        public List<Cliente> BuscarPorDni(int dni)
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.Where(e=>e.dni==dni).ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
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

        public int  PedidosPorCliente(int id_cliente)
        {
            Cliente cliente = new Cliente();
            int contarpedido = 0;
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    cliente = context.Cliente.Find(id_cliente);
                    foreach (Pedido pedido in cliente.Pedido)
                    {
                        contarpedido++;   
                    }
                }
                return contarpedido;
            }
            catch (Exception ex)
            {
                return contarpedido;
            }
        }
        public List<Cliente> ListarCLientesConMasPedidos()
        {
            List<Cliente> clientes = new List<Cliente>();
            int pedidos = 0;
            int mayorcantidadpedidos = 0;
            List<Cliente> Clientestemp = new List<Cliente>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.ToList();
                    foreach (Cliente cliente in clientes){
                        pedidos = PedidosPorCliente(cliente.id_cliente);
                        if (pedidos > mayorcantidadpedidos)
                        {
                            mayorcantidadpedidos = pedidos;
                            Clientestemp.Clear();
                            Clientestemp.Add(cliente);
                        }
                        else if (pedidos == mayorcantidadpedidos)
                        {
                            mayorcantidadpedidos = pedidos;
                            Clientestemp.Add(cliente);
                        }

                    }
                }
                return Clientestemp;
            }
            catch (Exception ex)
            {
                return Clientestemp;
            }
        }

    }
}

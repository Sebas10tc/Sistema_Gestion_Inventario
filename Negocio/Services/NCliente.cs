using Datos;
using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();
        public String Registrar(Cliente cliente, int dni)
        {
            return dCliente.Registrar(cliente, dni);
        }

        public String Modificar(Cliente cliente, int dni)
        {
            return dCliente.Modificar(cliente, dni);
        }

        public String Eliminar(int id_cliente)
        {
            return dCliente.Eliminar(id_cliente);
        }

        public List<Cliente> ListarTodo()
        {
            return dCliente.ListarTodo();
        }
        public List<Cliente> BuscarPorDni(int dni)
        {
            return dCliente.BuscarPorDni(dni);

        }

        public String ObtenerNombre(int ID_Usuario)
        {
            return dCliente.ObtenerNombre(ID_Usuario);
        }

        public List<Cliente> ListarCLientesConMasPedidos()
        {
            return dCliente.ListarCLientesConMasPedidos();

        }


    }
}

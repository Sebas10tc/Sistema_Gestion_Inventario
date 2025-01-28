using Datos;
using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class NMetodoPago
    {
        private DMetodoPago dMetodoPago = new DMetodoPago();
        public List<MetodoPago> ListarTodo()
        {
            return dMetodoPago.ListarTodo();
        }

    }
}

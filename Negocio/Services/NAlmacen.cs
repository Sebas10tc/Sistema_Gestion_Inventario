using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlmacen
    {
        private DAlmacen dAlmacen = new DAlmacen();
        public List<Almacen> ListarTodo()
        {
            return dAlmacen.ListarTodo();
        }
    }
}

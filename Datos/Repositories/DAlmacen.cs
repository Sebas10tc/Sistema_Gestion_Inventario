using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAlmacen
    {
        public List<Almacen> ListarTodo()
        {
            List<Almacen> almacenes = new List<Almacen>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    almacenes = context.Almacen.ToList();
                }
                return almacenes;
            }
            catch (Exception ex)
            {
                return almacenes;
            }
        }
    }
}

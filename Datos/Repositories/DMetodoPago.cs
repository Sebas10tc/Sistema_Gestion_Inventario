using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class DMetodoPago
    {
        public List<MetodoPago> ListarTodo()
        {
            List<MetodoPago> metodoPago = new List<MetodoPago>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    metodoPago = context.MetodoPago.ToList();
                }
                return metodoPago;
            }
            catch (Exception ex)
            {
                return metodoPago;
            }
        }
    }
}

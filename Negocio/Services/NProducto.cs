using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class NProducto
    {
        private DProducto dProducto = new DProducto();

        public String Registrar(Producto producto, String Nombre)
        {
            return dProducto.Registrar(producto, Nombre);

        }

        public String Modificar(Producto producto, String Nombre)
        {
            return dProducto.Modificar(producto, Nombre);

        }

        public String Eliminar(int id_producto)
        {
            return dProducto.Eliminar(id_producto);

        }

        public List<Producto> ListarTodo()
        {
            return dProducto.ListarTodo();

        }

        public List<Producto> ListarProductosMasVendidos()
        {
            return dProducto.ListarProductosMasVendidos();

        }

        public List<Producto> ListarProductosBajoStock()
        {
            return dProducto.ListarProductosBajoStock();

        }

        public string AumentarStock(Producto producto, int stockAumenta)
        {
            return dProducto.AumentarStock(producto, stockAumenta);

        }
        public String DisminuirStock(Producto producto, int stockDisminuye)
        {
            return dProducto.DisminuirStock(producto, stockDisminuye);

        }
        public String ObtenerNombre(int ID_Usuario)
        {
            return dProducto.ObtenerNombre(ID_Usuario);
        }

        public List<Producto> ListarTodoConStock()
        {
            return dProducto.ListarTodoConStock();
        }

        public decimal ObtenerPrecio(int ID_Producto)
        {
            return dProducto.ObtenerPrecio(ID_Producto);
        }
    }
}

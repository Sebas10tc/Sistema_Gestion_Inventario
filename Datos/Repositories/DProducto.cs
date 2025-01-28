using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProducto
    {
        private DUsuario dUsuario = new DUsuario();

        public String Registrar(Producto producto, String Nombre)
        {
            List<Producto> productos = ListarTodo();
            bool existe = productos.Exists(p => p.nombre.Equals(Nombre));

            if (existe == true)
            {
                return "Producto ya existente \nIngrese un producto diferente ";
            }
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Producto.Add(producto);
                    context.SaveChanges();
                }
                return "Producto registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Producto producto, String Nombre)
        {
            List<Producto> productos = ListarTodo();
            bool existe = productos.Exists(p => p.nombre.Equals(Nombre));

            if (existe == true && producto.nombre != Nombre)
            {
                return "Producto ya existente \nIngrese un producto diferente ";
            }
            else if (existe == true && producto.nombre == Nombre)
            {
                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        Producto productoTemp = context.Producto.Find(producto.id_producto);
                        productoTemp.nombre = producto.nombre;
                        productoTemp.precio = producto.precio;
                        productoTemp.stock = producto.stock;
                        context.SaveChanges();
                    }
                    return "Producto modificado exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        Producto productoTemp = context.Producto.Find(producto.id_producto);
                        productoTemp.nombre = producto.nombre;
                        productoTemp.precio = producto.precio;
                        productoTemp.stock = producto.stock;
                        context.SaveChanges();
                    }
                    return "Producto modificado exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public String Eliminar(int id_producto)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Producto productoTemp = context.Producto.Find(id_producto);
                    context.Producto.Remove(productoTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Producto> ListarTodo()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }
        public List<Producto> ListarTodoConStock()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(p => p.stock > 0).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }
        public List<Producto> ListarProductosMasVendidos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        public List<Producto> ListarProductosBajoStock()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(p => p.stock < 30).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        public string AumentarStock(Producto producto, int stockAumenta)
        {

            try
            {
                using (var context = new FSI_TFEntities())
                {

                    Producto productoTemp = context.Producto.Find(producto.id_producto);
                    productoTemp.stock += stockAumenta;
                    productoTemp.updatedBy = producto.updatedBy;
                    productoTemp.updateTime = producto.updateTime;
                    context.SaveChanges();
                }
                return "Stock Aumentado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
        public String DisminuirStock(Producto producto, int stockDisminuye)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Producto productoTemp = context.Producto.Find(producto.id_producto);
                    productoTemp.stock -= stockDisminuye;
                    
                    
                    productoTemp.updatedBy = producto.updatedBy;
                    productoTemp.updateTime = producto.updateTime;
                    context.SaveChanges();
                }

                return "Stock Disminuido";
            }
            catch (Exception ex)
            {
                return ex.Message;
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

        public decimal ObtenerPrecio(int ID_Producto)
        {
            List<Producto> productos = ListarTodo();
            Producto productoEncontrado = productos.Find(p => p.id_producto.Equals(ID_Producto));
            decimal precioFinal = productoEncontrado.precio;
            
            return precioFinal;
        }
    }
}

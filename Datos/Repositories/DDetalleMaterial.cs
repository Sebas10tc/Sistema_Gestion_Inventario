using Datos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDetalleMaterialProducto
    {
        private DUsuario dUsuario = new DUsuario();


        public String Asignar(DetalleMaterialProducto detalleMaterialProducto, int id_Material, int id_Producto)
        {
            List<DetalleMaterialProducto> detalleMaterialProductos = ListarTodo(id_Producto);
            bool existe = detalleMaterialProductos.Exists(d => d.id_material.Equals(id_Material));

            if (existe == true)
            {
                return "Ya existe ese material en el producto";
            }
            else 
            { 

                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        context.DetalleMaterialProducto.Add(detalleMaterialProducto);
                        context.SaveChanges();
                    }
                    return "Material asignado correctamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public String Desasignar(int id_DetalleMaterialProducto)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    DetalleMaterialProducto detalleTemp = context.DetalleMaterialProducto.Find(id_DetalleMaterialProducto);
                    context.DetalleMaterialProducto.Remove(detalleTemp);
                    context.SaveChanges();
                }
                return "Desasignado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(DetalleMaterialProducto detalleMaterialProducto, int id_Producto, int id_Material)
        {
            List<DetalleMaterialProducto> detalleMaterialProductos = ListarTodo(id_Producto);
            bool existe = detalleMaterialProductos.Exists(d => d.id_material.Equals(id_Material));

            if (existe == true && detalleMaterialProducto.id_material != id_Material)
            {
                return "Material ya existente \nIngrese un material diferente ";
            }
            
            else if(existe == true && detalleMaterialProducto.id_material == id_Material)
            {
                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        DetalleMaterialProducto detalleTemp = context.DetalleMaterialProducto.Find(detalleMaterialProducto.id_detalleMaterialProducto);
                        detalleTemp.id_producto = detalleMaterialProducto.id_producto;
                        detalleTemp.id_material = detalleMaterialProducto.id_material;
                        detalleTemp.cantidad = detalleMaterialProducto.cantidad;
                        detalleTemp.updatedBy = detalleMaterialProducto.updatedBy;
                        detalleTemp.updateTime = detalleMaterialProducto.updateTime;
                        context.SaveChanges();
                    }
                    return "Modificado exitosamente";
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
                        DetalleMaterialProducto detalleTemp = context.DetalleMaterialProducto.Find(detalleMaterialProducto.id_detalleMaterialProducto);
                        detalleTemp.id_producto = detalleMaterialProducto.id_producto;
                        detalleTemp.id_material = detalleMaterialProducto.id_material;
                        detalleTemp.cantidad = detalleMaterialProducto.cantidad;
                        detalleTemp.updatedBy = detalleMaterialProducto.updatedBy;
                        detalleTemp.updateTime = detalleMaterialProducto.updateTime;
                        context.SaveChanges();
                    }
                    return "Modificado exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            
        }

        public List<DetalleMaterialProducto> ListarTodo(int id_Producto)
        {
            List<DetalleMaterialProducto> detalleMaterialProductos= new List<DetalleMaterialProducto>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    detalleMaterialProductos = context.DetalleMaterialProducto.Where(d => d.id_producto.Equals(id_Producto)).ToList();
                }
                return detalleMaterialProductos;
            }
            catch (Exception ex)
            {
                return detalleMaterialProductos;
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

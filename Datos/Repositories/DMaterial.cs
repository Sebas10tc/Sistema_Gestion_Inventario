using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMaterial
    {
        private DUsuario dUsuario = new DUsuario();

        public String Registrar(Material material, String Color, String Nombre)
        {
            List<Material> materiales = ListarTodo();
            bool existe = materiales.Exists(m => m.color.Equals(Color) && m.nombre.Equals(Nombre));

            if (existe == true)
            {
                return "Material ya existente \nIngrese un material/color diferente ";
            }
            else
            {
                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        context.Material.Add(material);
                        context.SaveChanges();
                    }
                    return "Material agregado exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public String Modificar(Material material, String Color, String Nombre)
        {
            List<Material> materiales = ListarTodo();
            bool existe = materiales.Exists(m => m.color.Equals(Color) && m.nombre.Equals(Nombre));

            if (existe == true)
            {
                return "Material ya existente \nIngrese un material/color diferente ";
            }
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Material materialTemp = context.Material.Find(material.id_material);
                    materialTemp.nombre = material.nombre;
                    materialTemp.color = material.color;
                    materialTemp.stock = material.stock;
                    materialTemp.id_almacen = material.id_almacen;
                    materialTemp.updatedBy = material.updatedBy;
                    materialTemp.updateTime = material.updateTime;
                    context.SaveChanges();
                }
                return "Material modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_material)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Material materialTemp = context.Material.Find(id_material);
                    context.Material.Remove(materialTemp);
                    context.SaveChanges();
                }
                return "Material eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Material> ListarTodo()
        {
            List<Material> materiales = new List<Material>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    materiales = context.Material.ToList();
                }
                return materiales;
            }
            catch (Exception ex)
            {
                return materiales;
            }
        }
        public List<Material> ListarTodoConStock()
        {
            List<Material> materiales = new List<Material>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    materiales = context.Material.Where(m => m.stock > 0).ToList();
                }
                return materiales;
            }
            catch (Exception ex)
            {
                return materiales;
            }
        }

        public List<Material> ListarMaterialesConBajoStock()
        {
            List<Material> materiales = new List<Material>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    materiales = context.Material.Where(m => m.stock < 100).ToList();
                }
                return materiales;
            }
            catch (Exception ex)
            {
                return materiales;
            }
        }

        public List<Material> BuscarMaterialesPorColor(String Color)
        {
            List<Material> materiales = new List<Material>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    materiales = context.Material.Where(m => m.color.Equals(Color)).ToList();
                }
                return materiales;
            }
            catch (Exception ex)
            {
                return materiales;
            }
        }
        public List<Material> BuscarMaterialesPorNombre(String Nombre)
        {
            List<Material> materiales = new List<Material>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    materiales = context.Material.Where(m => m.nombre.Contains(Nombre)).ToList();
                }
                return materiales;
            }
            catch (Exception ex)
            {
                return materiales;
            }
        }

        public string AumentarStock(Material material, int stockAumenta)
        {

            try
            {
                using (var context = new FSI_TFEntities())
                {

                    Material materialTemp = context.Material.Find(material.id_material);
                    materialTemp.stock += stockAumenta;
                    materialTemp.updatedBy = material.updatedBy;
                    materialTemp.updateTime = material.updateTime;
                    context.SaveChanges();
                }
                return "Stock Aumentado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
        public String DisminuirStock(Material material, int stockDisminuye)
        {
            List<Material> materiales = new List<Material>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Material materialTemp = context.Material.Find(material.id_material);

                    materialTemp.stock -= stockDisminuye;
                    
                    materialTemp.updatedBy = material.updatedBy;
                    materialTemp.updateTime = material.updateTime;
                    context.SaveChanges();
                }
                
                return "Stock Disminuido";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Material> BuscarMaterialesPorAlmacen(int Id_almacen)
        {
            List<Material> materiales = new List<Material>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    materiales = context.Material.Where(m => m.id_almacen.Equals(Id_almacen)).ToList();
                }
                return materiales;
            }
            catch (Exception ex)
            {
                return materiales;
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

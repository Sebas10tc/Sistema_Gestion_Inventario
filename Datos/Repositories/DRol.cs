using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRol
    {
        // Aun en duda, si debe existir solamente dos roles preestablecidos
        public String Registrar(Rol rol, String NombreRol)
        {
            List<Rol> roles = ListarTodo();
            bool existe = roles.Exists(r => r.nombre.Equals(NombreRol));

            if (existe == true)
            {
                return "Ya existe el rol " + NombreRol;
            }
            else
            {
                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        context.Rol.Add(rol);
                        context.SaveChanges();
                    }
                    return "Rol agregado exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        // Modificar unicamente la descripción
        public String Modificar(Rol rol)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Rol rolTemp = context.Rol.Find(rol.id_rol);
                    //rolTemp.nombre = rol.nombre;
                    rolTemp.descripcion = rol.descripcion;
                    context.SaveChanges();
                }
                return "Rol modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Rol> ListarTodo()
        {
            List<Rol> roles = new List<Rol>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    roles = context.Rol.ToList();
                }
                return roles;
            }
            catch (Exception ex)
            {
                return roles;
            }
        }
    }
}

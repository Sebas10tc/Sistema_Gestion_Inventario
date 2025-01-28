using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuario
    {
        public String Registrar(Usuario usuario, String Username)
        {
            List<Usuario> usuarios = ListarTodo();
            bool existe = usuarios.Exists(u => u.username.Equals(Username));

            if (existe == true)
            {
                return "Username ya existente \nIngrese uno diferente ";
            }
            else
            {
                try
                {
                    using (var context = new FSI_TFEntities())
                    {
                        context.Usuario.Add(usuario);
                        context.SaveChanges();
                    }
                    return "Usuario agregado exitosamente";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public String Modificar(Usuario usuario)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Usuario usuarioTemp = context.Usuario.Find(usuario.id_usuario);
                    usuarioTemp.username = usuario.username;
                    usuarioTemp.password = usuario.password;
                    usuarioTemp.nombres = usuario.nombres;
                    usuarioTemp.apellidos = usuario.apellidos;
                    usuarioTemp.correo = usuario.correo;
                    usuarioTemp.id_rol = usuario.id_rol;
                    usuarioTemp.updatedBy = usuario.updatedBy;
                    usuarioTemp.updateTime = usuario.updateTime;
                    context.SaveChanges();
                }
                return "Usuario modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_usuario)
        {
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    Usuario usuarioTemp = context.Usuario.Find(id_usuario);
                    context.Usuario.Remove(usuarioTemp);
                    context.SaveChanges();
                }
                return "Usuario eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Usuario> ListarTodo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (var context = new FSI_TFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuario.ToList();
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                return usuarios;
            }
        }

        public int Login(String username, String password)
        {
            List<Usuario> usuarios = ListarTodo();
            Usuario usuarioEncontrado = usuarios.Find(u => u.username.Equals(username) && u.password.Equals(password));

            if (usuarioEncontrado == null)
            {
                return -1;
            }
            else
            {
                return usuarioEncontrado.id_usuario;
            }
        }

        public String VerificarRol(int ID_Usuario)
        {
            List<Usuario> usuarios = ListarTodo();
            Usuario usuarioEncontrado = usuarios.Find(u => u.id_usuario.Equals(ID_Usuario));
            if (usuarioEncontrado.id_rol == 1)
            {
                return "Administador";
            }
            else
            {
                return "Vendedor";
            }
        }

        public bool VerificarContrasenia(int ID_Usuario, String password)
        {
            List<Usuario> usuarios = ListarTodo();
            Usuario usuarioEncontrado = usuarios.Find(u=>u.id_usuario.Equals(ID_Usuario));

            if (password == usuarioEncontrado.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String ObtenerNombre(int ID_Usuario)
        {
            List<Usuario> usuarios = ListarTodo();
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

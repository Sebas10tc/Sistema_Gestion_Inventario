using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        public String Registrar(Usuario usuario, String Username)
        {
            return dUsuario.Registrar(usuario, Username);
        }

        public String Modificar(Usuario usuario)
        {
            return dUsuario.Modificar(usuario);
        }

        public String Eliminar(int id_usuario)
        {
            return dUsuario.Eliminar(id_usuario);
        }

        public List<Usuario> ListarTodo()
        {
            return dUsuario.ListarTodo();
        }

        public int Login(String username, String password)
        {
            return dUsuario.Login(username, password);
        }
        public String VerificarRol(int ID_Usuario)
        {
            return dUsuario.VerificarRol(ID_Usuario);
        }
        public bool VerificarContrasenia(int ID_Usuario, String password)
        {
            return dUsuario.VerificarContrasenia(ID_Usuario, password);
        }

        public String ObtenerNombre(int ID_Usuario)
        {
            return dUsuario.ObtenerNombre(ID_Usuario);
        }
    }
}

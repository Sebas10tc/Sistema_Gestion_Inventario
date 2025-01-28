using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRol
    {
        private DRol dRol = new DRol();
        // Aun en duda, si debe existir solamente dos roles preestablecidos
        public String Registrar(Rol rol, String NombreRol)
        {
            return dRol.Registrar(rol, NombreRol);
        }

        // Modificar unicamente la descripción
        public String Modificar(Rol rol)
        {
            return dRol.Modificar(rol);
        }

        public List<Rol> ListarTodo()
        {
            return dRol.ListarTodo();
        }
    }
}

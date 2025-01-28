using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Services
{
    public class NMaterial
    {
        private DMaterial dMaterial = new DMaterial();
        public String Registrar(Material material, String Color, String Nombre)
        {
            return dMaterial.Registrar(material, Color, Nombre);
        }

        public String Modificar(Material material, String Color, String Nombre)
        {
            return dMaterial.Modificar(material, Color, Nombre);
        }

        public String Eliminar(int id_material)
        {
            return dMaterial.Eliminar(id_material);
        }

        public List<Material> ListarTodo()
        {
            return dMaterial.ListarTodo();
        }
        public List<Material> ListarTodoConStock()
        {
            return dMaterial.ListarTodoConStock();
        }

        public List<Material> ListarMaterialesConBajoStock()
        {
            return dMaterial.ListarMaterialesConBajoStock();
        }

        public List<Material> BuscarMaterialesPorColor(String Color)
        {
            return dMaterial.BuscarMaterialesPorColor(Color);
        }
        public List<Material> BuscarMaterialesPorNombre(String Nombre)
        {
            return dMaterial.BuscarMaterialesPorNombre(Nombre);
        }

        public void AumentarStock(Material material, int stockAumenta)
        {
            dMaterial.AumentarStock( material, stockAumenta);
        }
        public void DisminuirStock(Material material, int stockDisminuye)
        {
            dMaterial.DisminuirStock( material, stockDisminuye);
        }

        public List<Material> BuscarMaterialesPorAlmacen(int Id_almacen)
        {
            return dMaterial.BuscarMaterialesPorAlmacen(Id_almacen);
        }
        public String ObtenerNombre(int ID_Usuario)
        {
            return dMaterial.ObtenerNombre(ID_Usuario);
        }

    }
}

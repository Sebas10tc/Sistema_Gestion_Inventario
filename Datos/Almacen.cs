//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Almacen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Almacen()
        {
            this.Material = new HashSet<Material>();
        }
    
        public int id_almacen { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public int capacidad { get; set; }
        public decimal area { get; set; }
        public decimal costoMensual { get; set; }
        public int createdBy { get; set; }
        public System.DateTime createDate { get; set; }
        public int updatedBy { get; set; }
        public System.DateTime updateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Material { get; set; }
    }
}

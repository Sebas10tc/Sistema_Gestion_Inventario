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
    
    public partial class DetallePedido
    {
        public int id_detallePedido { get; set; }
        public int id_pedido { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal precioProducto { get; set; }
        public decimal total { get; set; }
        public int createdBy { get; set; }
        public System.DateTime createDate { get; set; }
        public int updatedBy { get; set; }
        public System.DateTime updateTime { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}

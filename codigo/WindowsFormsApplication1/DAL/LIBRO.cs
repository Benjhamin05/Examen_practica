//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class LIBRO
    {
        public LIBRO()
        {
            this.VENTA = new HashSet<VENTA>();
        }
    
        public int idLibro { get; set; }
        public string titulo { get; set; }
        public string tipo { get; set; }
        public decimal costo { get; set; }
    
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}

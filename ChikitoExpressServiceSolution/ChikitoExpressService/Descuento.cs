//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChikitoExpressService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Descuento
    {
        public int idDescuentos { get; set; }
        public string nombre { get; set; }
        public decimal porcentage { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModicacion { get; set; }
        public bool estado { get; set; }
    }
}

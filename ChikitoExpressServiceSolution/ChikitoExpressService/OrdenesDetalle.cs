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
    
    public partial class OrdenesDetalle
    {
        public int idOrdenDetalle { get; set; }
        public int idOrden { get; set; }
        public int idElementosDeMenu { get; set; }
    
        public virtual ElementosDeMenu ElementosDeMenu { get; set; }
        public virtual Ordene Ordene { get; set; }
    }
}

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
    
    public partial class EnvioOrigin
    {
        public int idOrigin { get; set; }
        public int idEnvio { get; set; }
        public int idSucursal { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual Envio Envio { get; set; }
        public virtual Sucursale Sucursale { get; set; }
    }
}

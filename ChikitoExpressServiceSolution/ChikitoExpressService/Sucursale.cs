
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
    
public partial class Sucursale
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Sucursale()
    {

        this.EnvioDestinoes = new HashSet<EnvioDestino>();

        this.EnvioOrigins = new HashSet<EnvioOrigin>();

    }


    public int idSucursal { get; set; }

    public string nombre { get; set; }

    public int idDireccion { get; set; }



    public virtual Direccione Direccione { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<EnvioDestino> EnvioDestinoes { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<EnvioOrigin> EnvioOrigins { get; set; }

}

}


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
    
public partial class Zona
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Zona()
    {

        this.Direcciones = new HashSet<Direccione>();

    }


    public int idZona { get; set; }

    public int idMunicipio { get; set; }

    public string nombre { get; set; }

    public System.DateTime fechaCreacion { get; set; }

    public Nullable<System.DateTime> fechaModicacion { get; set; }

    public bool estado { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Direccione> Direcciones { get; set; }

    public virtual Municipio Municipio { get; set; }

}

}

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
    
public partial class Menu
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Menu()
    {

        this.ElementosDeMenus = new HashSet<ElementosDeMenu>();

    }


    public int idMenu { get; set; }

    public System.DateTime fechaCreacion { get; set; }

    public Nullable<System.DateTime> fechaModicacion { get; set; }

    public bool estado { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ElementosDeMenu> ElementosDeMenus { get; set; }

}

}
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
    
    public partial class ElementosDeMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ElementosDeMenu()
        {
            this.OrdenesDetalles = new HashSet<OrdenesDetalle>();
        }
    
        public int idElemento { get; set; }
        public Nullable<int> idBebida { get; set; }
        public int idMenu { get; set; }
        public Nullable<int> idPlato { get; set; }
        public bool disponible { get; set; }
    
        public virtual Bebida Bebida { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Plato Plato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenesDetalle> OrdenesDetalles { get; set; }
    }
}

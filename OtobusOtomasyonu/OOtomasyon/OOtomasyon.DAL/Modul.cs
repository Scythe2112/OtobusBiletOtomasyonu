//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOtomasyon.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Modul
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modul()
        {
            this.Formlar = new HashSet<Formlar>();
        }
    
        public int IDModul { get; set; }
        public string ModulAdi { get; set; }
        public string Modul1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Formlar> Formlar { get; set; }
    }
}

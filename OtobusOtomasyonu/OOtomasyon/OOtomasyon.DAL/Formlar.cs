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
    
    public partial class Formlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Formlar()
        {
            this.Yetki = new HashSet<Yetki>();
        }
    
        public int IDForm { get; set; }
        public string FormAdi { get; set; }
        public int ModulID { get; set; }
        public string Form { get; set; }
    
        public virtual Modul Modul { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yetki> Yetki { get; set; }
    }
}
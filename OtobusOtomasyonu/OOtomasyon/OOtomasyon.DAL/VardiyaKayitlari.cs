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
    
    public partial class VardiyaKayitlari
    {
        public int IDVardiye { get; set; }
        public int PersonelID { get; set; }
        public Nullable<System.DateTime> LoginGirisTarihi { get; set; }
        public Nullable<System.DateTime> LoginCikisTarihi { get; set; }
    
        public virtual Personel Personel { get; set; }
    }
}

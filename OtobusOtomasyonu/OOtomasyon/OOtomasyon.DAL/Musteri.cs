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
    
    public partial class Musteri
    {
        public int IDMusteri { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public string KartID { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<int> SehirID { get; set; }
        public string EPosta { get; set; }
        public string CepTelefonu { get; set; }
    
        public virtual Sehirler Sehirler { get; set; }
        public virtual MusteriKartlari MusteriKartlari { get; set; }
    }
}

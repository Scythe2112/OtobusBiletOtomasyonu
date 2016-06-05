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
    
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.IslemKayitlari = new HashSet<IslemKayitlari>();
            this.PersonelYetki = new HashSet<PersonelYetki>();
            this.SeferPersonel = new HashSet<SeferPersonel>();
            this.VardiyaKayitlari = new HashSet<VardiyaKayitlari>();
        }
    
        public int IDPersonel { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<System.DateTime> IseGirisTarihi { get; set; }
        public string Adres { get; set; }
        public int SehirID { get; set; }
        public string EvTelefonu { get; set; }
        public string CepTelefonu { get; set; }
        public string Aciklama { get; set; }
        public string ForografAdresi { get; set; }
        public int Unvan { get; set; }
        public int SubeID { get; set; }
        public string TcKimlikNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IslemKayitlari> IslemKayitlari { get; set; }
        public virtual Login Login { get; set; }
        public virtual Sehirler Sehirler { get; set; }
        public virtual Sube Sube { get; set; }
        public virtual Unvanlar Unvanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelYetki> PersonelYetki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeferPersonel> SeferPersonel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VardiyaKayitlari> VardiyaKayitlari { get; set; }
    }
}
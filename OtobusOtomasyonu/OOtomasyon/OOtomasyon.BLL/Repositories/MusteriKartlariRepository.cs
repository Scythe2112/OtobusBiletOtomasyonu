using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class MusteriKartlariRepository : IRepository<MusteriKartlari>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            MusteriKartlari deleted = db.MusteriKartlari.Find(itemID);
            db.MusteriKartlari.Remove(deleted);
            db.SaveChanges();
        }

        public void Delete(string itemID)
        {
            MusteriKartlari deleted = db.MusteriKartlari.Find(itemID);
            db.MusteriKartlari.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(MusteriKartlari item)
        {
            db.MusteriKartlari.Add(item);
            db.SaveChanges();
        }

        public List<MusteriKartlari> SelectAll()
        {
            return db.MusteriKartlari.ToList();
        }

        public MusteriKartlari SelectByID(int itemID)
        {
            return db.MusteriKartlari.Find(itemID);
        }

        public MusteriKartlari SelectByID(string itemID)
        {
            return db.MusteriKartlari.Find(itemID);
        }

        public bool ControlByBonusBilet(string itemID) {

            MusteriKartlari musteri = SelectByID(itemID);
            Promosyonlar pro =db.Promosyonlar.Where(x => x.BaslangicTarihi > DateTime.Now && x.BitisTarihi < DateTime.Now).FirstOrDefault();

            if (pro.PromosyonMiktari>=musteri.BiletSayisi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(MusteriKartlari item)
        {
            MusteriKartlari updated = db.MusteriKartlari.Find(item.IDKart);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

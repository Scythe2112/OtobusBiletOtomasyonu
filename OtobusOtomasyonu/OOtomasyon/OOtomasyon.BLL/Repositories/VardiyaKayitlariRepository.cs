using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class VardiyaKayitlariRepository:IRepository<VardiyaKayitlari>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            VardiyaKayitlari deleted = db.VardiyaKayitlari.Find(itemID);
            db.VardiyaKayitlari.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(VardiyaKayitlari item)
        {
            db.VardiyaKayitlari.Add(item);
            db.SaveChanges();
        }

        public List<VardiyaKayitlari> SelectAll()
        {
            return db.VardiyaKayitlari.ToList();
        }

        public VardiyaKayitlari SelectByID(int itemID)
        {
            return db.VardiyaKayitlari.Find(itemID);
        }

        public void Update(VardiyaKayitlari item)
        {
            VardiyaKayitlari updated = db.VardiyaKayitlari.Find(item.IDVardiye);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class MusteriRepository : IRepository<Musteri>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Musteri deleted = db.Musteri.Find(itemID);
            db.Musteri.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Musteri item)
        {
            db.Musteri.Add(item);
            db.SaveChanges();
        }

        public List<Musteri> SelectAll()
        {
            return db.Musteri.ToList();
        }

        public Musteri SelectByTC(string itemTc)
        {
            return db.Musteri.FirstOrDefault(x => x.TcKimlikNo == itemTc);
        }

        public bool MusteriControl(string itemTc)
        {
            Musteri personel = db.Musteri.FirstOrDefault(x => x.TcKimlikNo == itemTc);

            if (personel != null)
                return true;
            else
                return false;
        }
        public Musteri SelectByID(int itemID)
        {
            return db.Musteri.Find(itemID);
        }

        public void Update(Musteri item)
        {
            Musteri updated = db.Musteri.Find(item.IDMusteri);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

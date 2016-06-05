using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class KoltukDurumlariRepository : IRepository<KoltukDurumlari>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            KoltukDurumlari deleted = db.KoltukDurumlari.Find(itemID);
            db.KoltukDurumlari.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(KoltukDurumlari item)
        {
            db.KoltukDurumlari.Add(item);
            db.SaveChanges();
        }

        public List<KoltukDurumlari> SelectAll()
        {
            return db.KoltukDurumlari.ToList();
        }

        public KoltukDurumlari SelectByID(int itemID)
        {
            return db.KoltukDurumlari.Find(itemID);
        }

        public void Update(KoltukDurumlari item)
        {
            KoltukDurumlari updated = db.KoltukDurumlari.Find(item.IDKoltukDurum);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

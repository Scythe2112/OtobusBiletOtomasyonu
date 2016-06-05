using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class OdemeTipleriRepository : IRepository<OdemeTipleri>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            OdemeTipleri deleted = db.OdemeTipleri.Find(itemID);
            db.OdemeTipleri.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(OdemeTipleri item)
        {
            db.OdemeTipleri.Add(item);
            db.SaveChanges();
        }

        public List<OdemeTipleri> SelectAll()
        {
            return db.OdemeTipleri.ToList();
        }

        public OdemeTipleri SelectByID(int itemID)
        {
            return db.OdemeTipleri.Find(itemID);
        }

        public void Update(OdemeTipleri item)
        {
            OdemeTipleri updated = db.OdemeTipleri.Find(item.IDOdemeTipi);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

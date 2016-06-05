using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.DAL;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;

namespace OOtomasyon.BLL.Repositories
{
    public class SeferTipleriRepository : IRepository<SeferTipleri>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            SeferTipleri deleted = db.SeferTipleri.Find(itemID);
            db.SeferTipleri.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(SeferTipleri item)
        {
            db.SeferTipleri.Add(item);
            db.SaveChanges();
        }

        public List<SeferTipleri> SelectAll()
        {
            return db.SeferTipleri.ToList();
        }

        public SeferTipleri SelectByID(int itemID)
        {
            return db.SeferTipleri.Find(itemID);
        }

        public void Update(SeferTipleri item)
        {
            SeferTipleri updated = db.SeferTipleri.Find(item.IDSeferTipi);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

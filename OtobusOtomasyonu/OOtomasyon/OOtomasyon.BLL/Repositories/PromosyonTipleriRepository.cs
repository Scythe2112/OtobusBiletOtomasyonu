using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class PromosyonTipleriRepository : IRepository<PromosyonTipleri>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            PromosyonTipleri deleted = db.PromosyonTipleri.Find(itemID);
            db.PromosyonTipleri.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(PromosyonTipleri item)
        {
            db.PromosyonTipleri.Add(item);
            db.SaveChanges();
        }

        public List<PromosyonTipleri> SelectAll()
        {
            return db.PromosyonTipleri.Where(x=>x.IDPromosyonTipi!=11).ToList();
        }

        public PromosyonTipleri SelectByID(int itemID)
        {
            return db.PromosyonTipleri.Find(itemID);
        }

        public void Update(PromosyonTipleri item)
        {
            PromosyonTipleri updated = db.PromosyonTipleri.Find(item.IDPromosyonTipi);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

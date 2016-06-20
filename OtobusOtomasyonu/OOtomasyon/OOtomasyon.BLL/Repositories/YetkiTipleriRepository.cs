using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class YetkiTipleriRepository:IRepository<YetkiTipleri>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            YetkiTipleri deleted = db.YetkiTipleri.Find(itemID);
            db.YetkiTipleri.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(YetkiTipleri item)
        {
            db.YetkiTipleri.Add(item);
            db.SaveChanges();
        }

        public List<YetkiTipleri> SelectAll()
        {
            return db.YetkiTipleri.ToList();
        }

        public YetkiTipleri SelectByID(int itemID)
        {
            return db.YetkiTipleri.Find(itemID);
        }

        public void Update(YetkiTipleri item)
        {
            YetkiTipleri updated = db.YetkiTipleri.Find(item.YetkiTipleri1);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class SeferPersonelRepository : IRepository<SeferPersonel>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            SeferPersonel deleted = db.SeferPersonel.Find(itemID);
            db.SeferPersonel.Remove(deleted);
            db.SaveChanges();
        }
        public void DeleteAll(int itemID)
        {
            SeferDetay deleted = db.SeferDetay.Find(itemID);
            db.SeferPersonel.RemoveRange(deleted.SeferPersonel);
            db.SaveChanges();
        }

        public void Insert(SeferPersonel item)
        {
            db.SeferPersonel.Add(item);
            db.SaveChanges();
        }

        public List<SeferPersonel> SelectAll()
        {
            return db.SeferPersonel.ToList();
        }

        public SeferPersonel SelectByID(int itemID)
        {
            return db.SeferPersonel.Find(itemID);
        }

        public List<SeferPersonel> SelectByIDALL(int itemID)
        {
            return db.SeferPersonel.Where(x=>x.SeferDetayID==itemID).ToList();
        }

        public void Update(SeferPersonel item)
        {
            SeferPersonel updated = db.SeferPersonel.Find(item.IDSeferPersonel);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

    }
}

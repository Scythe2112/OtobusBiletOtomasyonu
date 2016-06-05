using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;

namespace OOtomasyon.BLL.Repositories
{
    public class OtobusDurumlariRepository : IRepository<OtobusDurumlari>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            OtobusDurumlari deleted = db.OtobusDurumlari.Find(itemID);
            db.OtobusDurumlari.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(OtobusDurumlari item)
        {
            db.OtobusDurumlari.Add(item);
            db.SaveChanges();
        }

        public List<OtobusDurumlari> SelectAll()
        {
            return db.OtobusDurumlari.ToList();
        }

        public OtobusDurumlari SelectByID(int itemID)
        {
            return db.OtobusDurumlari.Find(itemID);
        }

        public void Update(OtobusDurumlari item)
        {
            OtobusDurumlari updated = db.OtobusDurumlari.Find(item.IDOtobusDurumu);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

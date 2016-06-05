using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class SubeRepository : IRepository<Sube>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Sube silinen = db.Sube.Find(itemID);
            db.Sube.Remove(silinen);
            db.SaveChanges();
        }

        public void Insert(Sube item)
        {
            db.Sube.Add(item);
            db.SaveChanges();
        }

        public List<Sube> SelectAll()
        {
            return db.Sube.ToList();
        }

        public Sube SelectByID(int itemID)
        {
            return db.Sube.Find(itemID);
        }

        public void Update(Sube item)
        {
            Sube updated = db.Sube.Find(item.IDSube);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class ModulRepository:IRepository<Modul>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Modul deleted = db.Modul.Find(itemID);
            db.Modul.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Modul item)
        {
            db.Modul.Add(item);
            db.SaveChanges();
        }

        public List<Modul> SelectAll()
        {
            return db.Modul.ToList();
        }

        public Modul SelectByID(int itemID)
        {
            return db.Modul.Find(itemID);
        }

        public void Update(Modul item)
        {
            Modul updated = db.Modul.Find(item.IDModul);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

    }
}

using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class OtobusRepository : IRepository<Otobus>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;
        public void Delete(int itemID)
        {
            Otobus silinen = db.Otobus.Find(itemID);
            db.Otobus.Remove(silinen);
            db.SaveChanges();

        }

        public void Insert(Otobus item)
        {
            db.Otobus.Add(item);
            db.SaveChanges();
        }

        public List<Otobus> SelectAll()
        {
            return db.Otobus.ToList();
        }

        public Otobus SelectByID(int itemID)
        {
            return db.Otobus.Find(itemID);
        }

        public void Update(Otobus item)
        {
            Otobus updated = db.Otobus.Find(item.IDOtobus);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

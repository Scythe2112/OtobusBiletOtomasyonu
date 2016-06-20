using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class SeferRepository : IRepository<Sefer>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Sefer silinen = db.Sefer.Find(itemID);
            db.Sefer.Remove(silinen);
            db.SaveChanges();
        }

        public void Insert(Sefer item)
        {
            db.Sefer.Add(item);
            db.SaveChanges();
        }

        public List<Sefer> SelectAll()
        {
            return db.Sefer.Where(s=>s.SeferDurum==true).ToList();
        }

        public Sefer SelectByID(int itemID)
        {
            return db.Sefer.Find(itemID);
        }

        public void Update(Sefer item)
        {
            Sefer updated = db.Sefer.Find(item.IDSefer);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

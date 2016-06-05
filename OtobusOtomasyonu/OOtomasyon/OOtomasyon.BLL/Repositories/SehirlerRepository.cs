using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{

    public class SehirlerRepository : IRepository<Sehirler>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Sehirler deleted = db.Sehirler.Find(itemID);
            db.Sehirler.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Sehirler item)
        {
            db.Sehirler.Add(item);
            db.SaveChanges();
        }

        public List<Sehirler> SelectAll()
        {
            return db.Sehirler.ToList();
        }

        public Sehirler SelectByID(int itemID)
        {
            return db.Sehirler.Find(itemID);
        }

        public void Update(Sehirler item)
        {
            Sehirler updated = db.Sehirler.Find(item.IDSehir);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

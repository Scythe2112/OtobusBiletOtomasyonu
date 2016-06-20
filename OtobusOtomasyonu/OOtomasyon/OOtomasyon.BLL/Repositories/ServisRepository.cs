using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;

namespace OOtomasyon.BLL.Repositories
{
    public class ServisRepository : IRepository<Servis>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Servis deleted = db.Servis.Find(itemID);
            db.Servis.Remove(deleted);
            db.SaveChanges();
        }

        public void DeleteAll(int itemID)
        {
            SeferDetay deleted = db.SeferDetay.Find(itemID);
            db.Servis.RemoveRange(deleted.Servis);
            db.SaveChanges();
        }

        public void Insert(Servis item)
        {
            db.Servis.Add(item);
            db.SaveChanges();
        }

        public List<Servis> SelectAll()
        {
            return db.Servis.ToList();
        }

        public Servis SelectByID(int itemID)
        {
            return db.Servis.Find(itemID);
        }

        public void Update(Servis item)
        {
            Servis updated = db.Servis.Find(item.IDServis);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

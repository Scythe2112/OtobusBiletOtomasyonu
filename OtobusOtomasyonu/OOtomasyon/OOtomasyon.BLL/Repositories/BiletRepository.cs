using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;


namespace OOtomasyon.BLL.Repositories
{
    public class BiletRepository : IRepository<Bilet>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Bilet deleted = db.Bilet.Find(itemID);
            db.Bilet.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Bilet item)
        {
            db.Bilet.Add(item);
            db.SaveChanges();
        }

        public List<Bilet> SelectAll()
        {
            return db.Bilet.ToList();
        }

        public Bilet SelectByID(int itemID)
        {
            return db.Bilet.Find(itemID);
        }

        public List<Bilet> SelectBySeferDetayID(int seferDetayId)
        {
            return db.Bilet.Where(x=> x.SeferDetayID == seferDetayId).ToList();
        }

        public void Update(Bilet item)
        {
            Bilet updated = db.Bilet.Find(item.IDBilet);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

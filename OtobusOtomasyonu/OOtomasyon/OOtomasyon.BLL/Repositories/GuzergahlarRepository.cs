using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class GuzergahlarRepository : IRepository<Guzergahlar>
    {

        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Guzergahlar deleted = db.Guzergahlar.Find(itemID);
            db.Guzergahlar.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Guzergahlar item)
        {
            db.Guzergahlar.Add(item);
            db.SaveChanges();
        }

        public List<Guzergahlar> SelectAll()
        {
            return db.Guzergahlar.ToList();
        }

        public Guzergahlar SelectByID(int itemID)
        {
            return db.Guzergahlar.Find(itemID);
        }

        public void Update(Guzergahlar item)
        {
            Guzergahlar updated = db.Guzergahlar.Find(item.IDGuzergah);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

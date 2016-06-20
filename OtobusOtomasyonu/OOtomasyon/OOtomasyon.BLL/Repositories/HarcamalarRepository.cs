using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class HarcamalarRepository:IRepository<Harcamalar>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Harcamalar deleted = db.Harcamalar.Find(itemID);
            db.Harcamalar.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Harcamalar item)
        {
            db.Harcamalar.Add(item);
            db.SaveChanges();
        }

        public List<Harcamalar> SelectAll()
        {
            return db.Harcamalar.ToList();
        }

        public Harcamalar SelectByID(int itemID)
        {
            return db.Harcamalar.Find(itemID);
        }

        public void Update(Harcamalar item)
        {
            Harcamalar updated = db.Harcamalar.Find(item.IDHarcama);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

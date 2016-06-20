using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class SeferGuzergahiRepository : IRepository<SeferGuzergahi>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            SeferGuzergahi deleted = db.SeferGuzergahi.Find(itemID);
            db.SeferGuzergahi.Remove(deleted);
            db.SaveChanges();
        }
        public void DeleteAll(int itemID)
        {
            Sefer deleted = db.Sefer.Find(itemID);
            db.SeferGuzergahi.RemoveRange(deleted.SeferGuzergahi);
            db.SaveChanges();
        }

        public void Insert(SeferGuzergahi item)
        {
            db.SeferGuzergahi.Add(item);
            db.SaveChanges();
        }

        public List<SeferGuzergahi> SelectAll()
        {
            return db.SeferGuzergahi.ToList();
        }

        public SeferGuzergahi SelectByID(int itemID)
        {
            return db.SeferGuzergahi.Find(itemID);
        }

        public void Update(SeferGuzergahi item)
        {
            SeferGuzergahi updated = db.SeferGuzergahi.Find(item.IDSeferGuzergahi);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public List<SeferGuzergahi> SeferGuzergahiGetir(int itemID)
        {
            return db.SeferGuzergahi.Where(x => x.SeferID == itemID).OrderBy(y=>y.GuzergahSirasi).ToList();
        }

    }
}

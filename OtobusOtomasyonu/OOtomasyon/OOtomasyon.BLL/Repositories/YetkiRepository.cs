using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class YetkiRepository:IRepository<Yetki>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Yetki deleted = db.Yetki.Find(itemID);
            db.Yetki.Remove(deleted);
            db.SaveChanges();
        }

        public void DeleteAll(int personelid)
        {
            foreach (Yetki item in db.Yetki.Where(y=>y.PersonelID==personelid).ToList())
            {
            db.Yetki.Remove(item);
            db.SaveChanges();
            }
        }

        public void Insert(Yetki item)
        {
            db.Yetki.Add(item);
            db.SaveChanges();
        }

        public List<Yetki> SelectAll()
        {
            return db.Yetki.ToList();
        }

        public List<Yetki> SelectAllByID(int personelId)
        {
            return db.Yetki.Where(y=>y.PersonelID==personelId).ToList();
        }

        public Yetki SelectByID(int itemID)
        {
            return db.Yetki.Find(itemID);
        }

        public void Update(Yetki item)
        {
            Yetki updated = db.Yetki.Find(item.IDYetki);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

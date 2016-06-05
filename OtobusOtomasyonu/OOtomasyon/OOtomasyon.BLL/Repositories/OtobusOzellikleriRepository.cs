using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;

namespace OOtomasyon.BLL.Repositories
{
    public class OtobusOzellikleriRepository : IRepository<OtobusOzellikleri>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            OtobusOzellikleri deleted = db.OtobusOzellikleri.Find(itemID);
            db.OtobusOzellikleri.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(OtobusOzellikleri item)
        {
            db.OtobusOzellikleri.Add(item);
            db.SaveChanges();
        }

        public List<OtobusOzellikleri> SelectAll()
        {
            return db.OtobusOzellikleri.ToList();
        }

        public OtobusOzellikleri SelectByID(int itemID)
        {
            return db.OtobusOzellikleri.Find(itemID);
        }

        public int SelectByName(string OzellikAdi)
        {
            return db.OtobusOzellikleri.FirstOrDefault(x => x.OtobusOzellik.Equals(OzellikAdi)).IDOtobusOzellik;
        }

        public void Update(OtobusOzellikleri item)
        {
            OtobusOzellikleri updated = db.OtobusOzellikleri.Find(item.IDOtobusOzellik);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

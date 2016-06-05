using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;

namespace OOtomasyon.BLL.Repositories
{
    public class OtobusTipleriRepository : IRepository<OtobusTipleri>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            OtobusTipleri deleted = db.OtobusTipleri.Find(itemID);
            db.OtobusTipleri.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(OtobusTipleri item)
        {
            db.OtobusTipleri.Add(item);
            db.SaveChanges();
        }

        public List<OtobusTipleri> SelectAll()
        {
            return db.OtobusTipleri.ToList();
        }

        public OtobusTipleri SelectByID(int itemID)
        {
            return db.OtobusTipleri.Find(itemID);
        }

        public void Update(OtobusTipleri item)
        {
            OtobusTipleri updated = db.OtobusTipleri.Find(item.IDOtobusTipi);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;

namespace OOtomasyon.BLL.Repositories
{
    public class OtobusOzellikDetayRepository : IRepository<OtobusOzellikDetay>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            OtobusOzellikDetay deleted = db.OtobusOzellikDetay.Find(itemID);
            db.OtobusOzellikDetay.Remove(deleted);
            db.SaveChanges();
        }

        public void DeleteAll(int itemID)
        {
            List<OtobusOzellikDetay> deletedList = db.OtobusOzellikDetay.Where(x=>x.OtobusID==itemID).ToList();
            foreach (OtobusOzellikDetay item in deletedList)
            {
                Delete(item.IDOtobusOzellikDetay);
            }
        }

        public void Insert(OtobusOzellikDetay item)
        {
            db.OtobusOzellikDetay.Add(item);
            db.SaveChanges();
        }

        public List<OtobusOzellikDetay> SelectAll()
        {
            return db.OtobusOzellikDetay.ToList();
        }

        public List<OtobusOzellikDetay> SelectAllByID(int itemID)
        {
            return db.OtobusOzellikDetay.Where(x=> x.OtobusOzellikID==itemID).ToList();
        }

        public OtobusOzellikDetay SelectByID(int itemID)
        {
            return db.OtobusOzellikDetay.Find(itemID);
        }

        public void Update(OtobusOzellikDetay item)
        {
            OtobusOzellikDetay updated = db.OtobusOzellikDetay.Find(item.IDOtobusOzellikDetay);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

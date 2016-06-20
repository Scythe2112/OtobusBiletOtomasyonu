using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class HarcamaTipleriRepository: IRepository<HarcamaTipleri>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            HarcamaTipleri deleted = db.HarcamaTipleri.Find(itemID);
            db.HarcamaTipleri.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(HarcamaTipleri item)
        {
            db.HarcamaTipleri.Add(item);
            db.SaveChanges();
        }

        public List<HarcamaTipleri> SelectAll()
        {
            return db.HarcamaTipleri.ToList();
        }

        public HarcamaTipleri SelectByID(int itemID)
        {
            return db.HarcamaTipleri.Find(itemID);
        }

        public bool HarcamaTipiVarMi(string harcamaTipi)
        {
            return db.HarcamaTipleri.FirstOrDefault(x=>x.HarcamaTipi==harcamaTipi)==null?false:true;
        }

        public void Update(HarcamaTipleri item)
        {
            HarcamaTipleri updated = db.HarcamaTipleri.Find(item.IDHarcamaTipi);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

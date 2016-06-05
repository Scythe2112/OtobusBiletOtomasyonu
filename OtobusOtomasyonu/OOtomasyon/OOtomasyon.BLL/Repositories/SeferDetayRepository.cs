using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class SeferDetayRepository : IRepository<SeferDetay>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            SeferDetay deleted = db.SeferDetay.Find(itemID);
            db.SeferDetay.Remove(deleted);
            db.SaveChanges();
        }
        public void DeleteAll(int itemID) {

            Sefer deleted = db.Sefer.Find(itemID);
            db.SeferDetay.RemoveRange(deleted.SeferDetay);
            db.SaveChanges();
        }

        public void Insert(SeferDetay item)
        {
            db.SeferDetay.Add(item);
            db.SaveChanges();
        }

        public List<SeferDetay> SelectAll()
        {
            return db.SeferDetay.ToList();
        }

        public List<SeferDetay> SelectAll(int itemID)
        {
            return db.SeferDetay.Where(x=> x.Sefer.IDSefer==itemID).ToList();
        }

        public SeferDetay SelectByID(int itemID)
        {
            return db.SeferDetay.Find(itemID);
        }

        public void Update(SeferDetay item)
        {
            SeferDetay updated = db.SeferDetay.Find(item.IDSeferDetay);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public List<SeferDetay> GuzergahaGoreSeferDetayGetir(int start, int end)
        {
            List<SeferDetay> seferDetaylar = new List<SeferDetay>();

            foreach (var item in db.Sefer)
            {
                SeferGuzergahi s = GetSefer((HashSet<SeferGuzergahi>)item.SeferGuzergahi, start);
                SeferGuzergahi e = GetSefer((HashSet<SeferGuzergahi>)item.SeferGuzergahi, end);
                if (s != null && e != null)
                {
                    if (s.SeferID == e.SeferID && s.GuzergahSirasi < e.GuzergahSirasi)
                    {
                        seferDetaylar.AddRange(s.Sefer.SeferDetay);
                    }
                }
            }

            return seferDetaylar;
        }

        public SeferGuzergahi GetSefer(HashSet<SeferGuzergahi> seferGuzergahlari, int guzergah)
        {

            SeferGuzergahi result = null;

            foreach (var item1 in seferGuzergahlari)
            {
                if (item1.Guzergahlar.IDGuzergah == guzergah)
                {
                    result = item1;
                    break;
                }
            }
            return result;
        }


    }
}

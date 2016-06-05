using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class PromosyonlarRepository : IRepository<Promosyonlar>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Promosyonlar deleted = db.Promosyonlar.Find(itemID);
            db.Promosyonlar.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Promosyonlar item)
        {
            db.Promosyonlar.Add(item);
            db.SaveChanges();
        }

        public List<Promosyonlar> SelectAll()
        {
            return db.Promosyonlar.ToList();
        }

        public Promosyonlar SelectAllActive(int promosyonTipi)
        {
            return db.Promosyonlar.Where(x => (x.BitisTarihi > DateTime.Now && x.BaslangicTarihi<DateTime.Now) && x.PromosyonTipiID== promosyonTipi).FirstOrDefault();
        }

        public List<Promosyonlar> SelectAllActive()
        {
            return db.Promosyonlar.Where(x => (x.BitisTarihi > DateTime.Now && x.BaslangicTarihi < DateTime.Now)).ToList();
        }

        public Promosyonlar SelectByID(int itemID)
        {
            return db.Promosyonlar.Find(itemID);
        }

        public void Update(Promosyonlar item)
        {
            Promosyonlar updated = db.Promosyonlar.Find(item.IDPromosyon);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

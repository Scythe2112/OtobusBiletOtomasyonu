using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;


namespace OOtomasyon.BLL.Repositories
{
    public class BiletRepository : IRepository<Bilet>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Bilet deleted = db.Bilet.Find(itemID);
            db.Bilet.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Bilet item)
        {
            db.Bilet.Add(item);
            db.SaveChanges();
        }

        public List<Bilet> SelectAll()
        {
            return db.Bilet.ToList();
        }

        public Bilet SelectByID(int itemID)
        {
            return db.Bilet.Find(itemID);
        }

        public List<Bilet> SelectBySeferDetayIDOnly(int seferDetaySefer)
        {
            return db.Bilet.Where(x => x.SeferDetayID == seferDetaySefer).ToList();
        }

        public List<Bilet> SelectBySeferDetayID(SeferDetay seferDetay,int start, int end,int binis,int inis)
        {

            return db.Bilet.ToList().Where(x => x.SeferDetayID == seferDetay.IDSeferDetay &&
           ((SelectByDestination(seferDetay.SeferID, x.BinisYeri) <= SelectByDestination(seferDetay.SeferID, inis)) && 
           (SelectByDestination(seferDetay.SeferID, x.InisYeri) > SelectByDestination(seferDetay.SeferID, binis)))).ToList();
        }

        public int SelectByDestination(int seferId,int yer)
        {
            return Convert.ToInt32(db.SeferGuzergahi.Where(x => x.SeferID == seferId && x.GuzergahID== yer).First().GuzergahSirasi);
        }

        public void Update(Bilet item)
        {
            Bilet updated = db.Bilet.Find(item.IDBilet);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

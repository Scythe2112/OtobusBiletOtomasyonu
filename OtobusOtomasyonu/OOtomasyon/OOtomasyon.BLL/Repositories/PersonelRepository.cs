using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
   public class PersonelRepository : IRepository<Personel>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Personel silinen = db.Personel.Find(itemID);
            db.Personel.Remove(silinen);
            db.SaveChanges();
        }

        public void Insert(Personel item)
        {
            db.Personel.Add(item);
            db.SaveChanges();
        }

        public List<Personel> SelectAll()
        {
            return db.Personel.ToList();
        }

        public Personel SelectByID(int itemID)
        {
            return db.Personel.Find(itemID);
        }

        public Personel SelectByTC(string itemTc)
        {
            return db.Personel.FirstOrDefault(x=>x.TcKimlikNo== itemTc);
        }

        public bool PersonelControl(string itemTc)
        {
            Personel personel= db.Personel.FirstOrDefault(x => x.TcKimlikNo == itemTc);

            if (personel!=null)
                return true;
            else
                return false;
        }

        public void Update(Personel item)
        {
            Personel updated = db.Personel.Find(item.IDPersonel);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class FormlarRepository:IRepository<Formlar>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Formlar deleted = db.Formlar.Find(itemID);
            db.Formlar.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Formlar item)
        {
            db.Formlar.Add(item);
            db.SaveChanges();
        }

        public List<Formlar> SelectAll()
        {
            return db.Formlar.ToList();
        }

        public Formlar SelectByID(int itemID)
        {
            return db.Formlar.Find(itemID);
        }

        public Formlar FormControl(string form,int modulid)
        {
            return db.Formlar.Where(frm=>frm.Form== form && frm.ModulID==modulid).FirstOrDefault();
        }

        public void Update(Formlar item)
        {
            Formlar updated = db.Formlar.Find(item.IDForm);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}

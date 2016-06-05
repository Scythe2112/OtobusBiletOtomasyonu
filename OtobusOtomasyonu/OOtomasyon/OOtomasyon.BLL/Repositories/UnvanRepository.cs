using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOtomasyon.BLL.Repositories
{
    public class UnvanRepository : IRepository<Unvanlar>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;
        public void Delete(int itemID)
        {
            throw new NotImplementedException();
        }
       
        public void Insert(Unvanlar item)
        {
            db.Unvanlar.Add(item);
            db.SaveChanges();
        }

        public List<Unvanlar> SelectAll()
        {
            return db.Unvanlar.ToList();
        }

        public Unvanlar SelectByID(int itemID)
        {
            throw new NotImplementedException();
        }

        public void Update(Unvanlar item)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.DAL;

namespace OOtomasyon.BLL
{
    public class DbTool
    {
        private static pnuretSu_otobusEntities _dbInstance;
        public static pnuretSu_otobusEntities DBInstance
        {
            get
            {
                if (_dbInstance == null)
                    _dbInstance = new pnuretSu_otobusEntities();
                return _dbInstance;
            }


        }
    }
}

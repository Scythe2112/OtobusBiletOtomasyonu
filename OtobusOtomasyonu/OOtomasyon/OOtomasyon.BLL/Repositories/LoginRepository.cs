using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOtomasyon.BLL.OOtomasyon.BLL.Repositories;
using OOtomasyon.DAL;

namespace OOtomasyon.BLL.Repositories
{
    public class LoginRepository : IRepository<Login>
    {
        pnuretSu_otobusEntities db = DbTool.DBInstance;

        public void Delete(int itemID)
        {
            Login deleted = db.Login.Find(itemID);
            db.Login.Remove(deleted);
            db.SaveChanges();
        }

        public void Insert(Login item)
        {
            db.Login.Add(item);
            db.SaveChanges();
        }

        public List<Login> SelectAll()
        {
            return db.Login.ToList();
        }

        public Login SelectByID(int itemID)
        {
            return db.Login.Find(itemID);
        }

        public void Update(Login item)
        {
            Login updated = db.Login.Find(item.PersonelID);
            db.Entry(updated).CurrentValues.SetValues(updated);
            db.SaveChanges();
        }

        public Personel LoginControl(string kullaniciAdi,string parola, out string errorText)
        {

            Login login = db.Login.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi);

            if (login != null)
            {
                if (login.Parola==parola)
                {
                    errorText = "Giriş Başarılı";
                    return db.Personel.Find(login.PersonelID);
                }
                else
                {
                    errorText= "Parola yanlış !";
                    return null;
                }
            }
            else
            {
                errorText = "Kullanıcı Adı hatalı ve ya böyle bir kullanıcı mevcut değil !";
                return null;
            }   
        }
    }
}

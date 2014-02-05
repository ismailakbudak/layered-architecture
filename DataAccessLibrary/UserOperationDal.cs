using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class UserOperationDal : Base
    {
        public bool add_User(USERS kisi)
        {
            bool result = false;

            try
            {
                base.DbObject.USERS.Add(kisi);
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
     
        public bool isExist(string isim, string sifre)
        {
            bool result = false;
            try
            {
                var sonuc = base.DbObject.USERS.Where(c => c.GroupID == 1 && c.UserName == isim && c.Password == sifre).Count();
                if (sonuc > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public bool update_User()
        {
            bool result = false;
            try
            {
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public List<USERS> get_All_Users()
        {
            var result = (from inc in base.DbObject.USERS select inc).ToList();
            return result;
        }

        public bool delete_User(int ID)
        {
            bool result = false;
            USERS _user = base.DbObject.USERS.Where(c => c.ID == ID).FirstOrDefault();
            try
            {
                base.DbObject.USERS.Remove(_user);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public USERS get(string name , string email)
        {
            USERS user = base.DbObject.Database.SqlQuery<USERS>("select * from USERS where UserName='" + name + "' or Email='"+email+"'").FirstOrDefault();
            return user;
        }

        /// <summary>
        /// email adresine göre dönen kullanıcıyı döndürür
        /// </summary>
        /// <param name="pEmail">string türünde email parametresi alır </param>
        /// <returns>USERS türünde veri döndürür</returns>
        public USERS Get_For_Update(string pEmail)
        {
            USERS user = base.DbObject.USERS.Where(c => c.Email.CompareTo(pEmail).Equals(0)).FirstOrDefault();
            return user;
        }

        // Kullanıcı Adı ve Emaile Göre Gelen Kullanıcı 
        public USERS Get_User_With_And(string andUserName, string andEmail)
        {
            USERS user = base.DbObject.Database.SqlQuery<USERS>("select * from USERS where UserName='" + andUserName + "' and Email='" + andEmail + "'").FirstOrDefault();
            return user;
        }

        // Kullanıcı Adı Ve Sifre ile ilgili kullanıcılar
        public USERS UserEnter(string pUserName, string pSifre)
        {
            USERS user = base.DbObject.Database.SqlQuery<USERS>("select * from USERS where UserName='" + pUserName + "' and Password='" + pSifre + "'").FirstOrDefault();
            return user;
        }

        // Email adresine göre kullanıcı siler
        public bool Delete_User(string pEmail)
        {
            bool value = false;
            try
            {
                base.DbObject.Database.SqlQuery<USERS>("DELETE FROM USERS WHERE Email = '" + pEmail + "'").FirstOrDefault();
                value = true;
            }
            catch (Exception)
            {
                value = false;
            }
            return value;
        }

        /// <summary>
        ///  Parametrede gelen UserID'li kişiyi döndüren metot
        /// </summary>
        /// <param name="pUserID">USERS ID</param>
        /// <returns>USERS tipinde veri dönder yoksa null döner</returns>
        public USERS Get_With_ID(int pUserID)
        {
            var result = base.DbObject.USERS.Where(c => c.ID == pUserID).FirstOrDefault();
            return result;
        }

        public List<USERS> Adminleri_Listele()
        {
            return base.DbObject.USERS.Where(c => c.GroupID == 1).ToList();
        }
    }
}

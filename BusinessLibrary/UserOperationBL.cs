using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
    public class UserOperationBL : Base
    {

        /// <summary>
        /// USERS nesnesinde değişiklik yapıldıktan sonra veritababnın da da bu USERS ı güncelleyen metot
        /// </summary>
        /// <returns>Güncellenirse TRUE Hata oluşursa FALSE döner</returns>
        public bool update_User()
        {
            return base.UserOperationDalObject.update_User();
        }

        /// <summary>
        /// List tipinde tüm kullanıcıları döndürür
        /// </summary>
        /// <returns>List<USERS> Tipinde veri döner</returns>
        public List<USERS> get_All_Users()
        {
            return base.UserOperationDalObject.get_All_Users();
        }

        /// <summary>
        /// Parametre de Gelen ID li USERS'ı siler
        /// </summary>
        /// <param name="ID">USERS ID </param>
        /// <returns>Silinirse TRUE silinmezse FALSE döner</returns>
        public bool delete_User(int ID)
        {
            return base.UserOperationDalObject.delete_User(ID);
        }

        /// <summary>
        ///  Parametre Olarak gelen name veya email ile ilgili kullanıcı varsa ilk değeri döndürür 
        /// </summary>
        /// <param name="name"> USERS name</param>
        /// <param name="email">USERS email</param>
        /// <returns>USERS TİPİNDE TEK DEĞER EĞER YOKSA NULL DÖNER</returns>
        public USERS get(string name, string email)
        {
            return base.UserOperationDalObject.get(name, email);
        }

        /// <summary>
        /// Parametre Olarak gelen isim ve şifreli bir USERS var mı yok mu kontrol eder
        /// </summary>
        /// <param name="isim">USERS Name</param>
        /// <param name="sifre">USERS Password</param>
        /// <returns>Bu isim ve şifreli USERS sayısı Sıfırdan Büyükse True değilse False Döndürür</returns>
        public bool isExist(string isim, string sifre)
        {
            return base.UserOperationDalObject.isExist(isim, sifre);
        }

        /// <summary>
        /// Parametre olarak gelen UserName ve Email'i aynı olan USERS'ı döndürür
        /// </summary>
        /// <param name="pUserName">USERS UserName</param>
        /// <param name="pEmail">USERS Email</param>
        /// <returns>USERS varsa ilk Değeri döndürür yoksa NULL döndürür</returns>
        public USERS Get_User_With_And(string pUserName, string pEmail)
        {
            return base.UserOperationDalObject.Get_User_With_And(pUserName, pEmail);
        }

        /// <summary>
        /// USERS tablosunda UserName ve Password'ü parametre dekilerle aynı olan kullanıcıyı döndürür
        /// </summary>
        /// <param name="pUserName">USERS USerName</param>
        /// <param name="pPassword">USERS Password</param>
        /// <returns>USERS varsa ilk değer yoksa null döner</returns>
        public USERS UserEnter(string pUserName, string pPassword)
        {
            return base.UserOperationDalObject.UserEnter(pUserName, pPassword);
        }

        /// <summary>
        ///  Parametre Olarak gelen name veya email ile ilgili kullanıcı varsa ilk değeri döndürür 
        /// </summary>
        /// <param name="name"> USERS name</param>
        /// <param name="email">USERS email</param>
        /// <returns>USERS TİPİNDE TEK DEĞER EĞER YOKSA NULL DÖNER</returns>
        public USERS Get(string name, string Email)
        {
            return base.UserOperationDalObject.get(name, Email);
        }

        /// <summary>
        /// Parametre Olarak gelen Emaile Göre USERS dödüren metot
        /// </summary>
        /// <param name="pEmail">USERS Email</param>
        /// <returns>USERS varsa ilk Değer yoksa NULL döner</returns>
        public USERS Get_For_Update(string pEmail)
        {
            return base.UserOperationDalObject.Get_For_Update(pEmail);
        }

        /// <summary>
        /// USERS tablosuna ekleme yapan metot
        /// </summary>
        /// <param name="user">USERS tipinde parametre alır</param>
        /// <returns>Eklenirse TRUE eklenemezse FALSE</returns>
        public bool Add_User(USERS user)
        {
            return base.UserOperationDalObject.add_User(user);
        }
        
        /// <summary>
        /// Parametre de Gelen Email'li USERS'ı siler
        /// </summary>
        /// <param name="ID">USERS Email </param>
        /// <returns>Silinirse TRUE silinmezse FALSE döner</returns>
        public bool Delete_User(string pEmail)
        {
            return base.UserOperationDalObject.Delete_User(pEmail);
        }

        /// <summary>
        ///  Parametrede gelen UserID'li kişiyi döndüren metot
        /// </summary>
        /// <param name="pUserID">USERS ID</param>
        /// <returns>USERS tipinde veri dönder yoksa null döner</returns>
        public USERS Get_With_ID(int pUserID)
        {
          return  base.UserOperationDalObject.Get_With_ID(pUserID);
        }
        /// <summary>
        /// Bu Fonksiyon Liste Şeklinde Tüm Admin Kullanıcıları Görüntüler...
        /// </summary>
        /// <returns></returns>
        public List<USERS> Adminleri_Listele()
        {
            return base.UserOperationDalObject.Adminleri_Listele();
        }
    }
}

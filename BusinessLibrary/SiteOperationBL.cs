using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
    public class SiteOperationBL : Base
    {
        /// <summary>
        ///  SITE tablosuna Site Ekleyen metot
        /// </summary>
        /// <param name="value">SITE tipinde parametre</param>
        /// <returns>Eklenirse TRUE eklenmezse FALSE</returns>
        public bool add_Site(SITE value)
        {
            return base.SiteOperationDalObject.add_Site(value);
        }
    
        /// <summary>
        /// SITE güncelleyen metot
        /// </summary>
        /// <returns>Güncellenirse TRUE güncellenemezse FALSE</returns>
        public bool update_Site()
        {
            return base.SiteOperationDalObject.update_Site();
        }
  
        /// <summary>
        /// parametre ile gelen ID li SITE'I silen metot
        /// </summary>
        /// <param name="ID">SITE ID</param>
        /// <returns>Silinirse TRUE silinemezse FALSE</returns>
        public bool delete_Site(int ID)
        {
            return base.SiteOperationDalObject.delete_Site(ID);
        }
      
        /// <summary>
        /// Admini Bilgilendirmek İçin ONAY Bekleyen Web Sitelerin Sayısını Döndürür.
        /// </summary>
        /// <returns></returns>
        public int onaybekleyensitelerinsayisi()
        {
            return base.SiteOperationDalObject.onaybekleyensiteler();
        }

        /// <summary>
        /// Onay Bekleyen Tüm Web Siteleri LİST şeklinde Döndürür.
        /// </summary>
        /// <returns></returns>
        public List<SITE> OnayBekleyenSiteleri_Al()
        {
            return base.SiteOperationDalObject.GetAll_Site();
        }
        /// <summary>
        /// İd'ye sahip web sitenin özelliklerini görüntülemek için yazılmıştır.
        /// </summary>
        /// <param name="id">id:WebSitenin İd'sidir.</param>
        /// <returns></returns>
        public SITE Get_This_WebSite(int id)
        {
            return base.SiteOperationDalObject.Get_This_WebSite(id);
        }
        /// <summary>
        /// Bu fonksiyon içine aldığı id değerindeki siteyi onaylayacaktır.
        /// </summary>
        /// <param name="id">Site id'si</param>
        /// <returns></returns>
        public bool Site_Onayla(int id)
        {
            bool result = base.SiteOperationDalObject.Site_Onayla(id);
            return result;
        }

        /// <summary>
        /// Parametrede gelen UserID ye ait Siteleri döndürür
        /// </summary>
        /// <param name="pUserID">SITE UserID</param>
        /// <returns>List<SITE> list tipinde veri döner</SITE></returns>
        public List<SITE> Get_Site(int pUserID)
        {
            return base.SiteOperationDalObject.Get_Site(pUserID);
        }

        /// <summary>
        ///  Sitenin bilgilerini SiteUserInfo turunde list şeklinde döndüren metot
        /// </summary>
        /// <param name="pUserID"> SITE UserID </param>
        /// <returns>List<SiteUserInfo> list tipinde veri döndürür</SiteUserInfo></returns>
        public List<SiteUserInfo> Get_Site_Info(int pUserID)
        {
            return base.SiteOperationDalObject.Get_Site_Info(pUserID);
        }

        /// <summary>
        ///  Parametre ile gelen SiteID ye göre siteyi döndüren metot
        /// </summary>
        /// <param name="pSiteID">SITE ID</param>
        /// <returns>SITE tipinde veri döndürür</returns>
        public SITE Get_Site_Info_By_SiteID(int pSiteID)
        {
            return base.SiteOperationDalObject.Get_Site_Info_By_SiteID(pSiteID);
        }

        /// <summary>
        ///  Parametre ile gelen SiteName e göre olan siteyi getiren metot
        /// </summary>
        /// <param name="pSiteName"> SITE SiteName</param>
        /// <returns></returns>
        public SITE Get_Site_By_Name(string pSiteName)
        {
            return base.SiteOperationDalObject.Get_Site_By_Name(pSiteName);
        }

        /// <summary>
        ///  Bu metot En son eklenen Parametrede gelen pCount Sitenin Bilgilerini SiteInformation Türünde List olarak döndürür
        /// </summary>
        /// <param name="pCount"> Kaçtane web ssitesinin bilgisi isteniyorsa</param>
        /// <returns>List<SiteInformation> List tütünde veri döner</SiteInformation></returns>
        public List<SiteInformation> Get_Site_Anasayfa(int pCount)
        {
            return base.SiteOperationDalObject.Get_Site_Anasayfa(pCount);
        }

        /// <summary>
        ///  En cok oy alan site lerin bilgilerini SearchResult türünde list olarak döndüren metot Parametrede gelen sayı kadarını döndürür
        /// </summary>
        /// <param name="pCount"> Kaç site döndürülecek ise onu döndürür</param>
        /// <returns> List türünde veri döner</returns>
        public List<SearchResult> Select_Best_Sites(int pCount)
        {
            return base.SiteOperationDalObject.Select_Best_Sites(pCount);
          
        }

        /// <summary>
        /// Parametrede gelen SubCategory Türünde en ok oy alan site lerin bilgilerini SearchResult türünde list olarak döndüren metot Parametrede gelen sayı kadarını döndürür
        /// </summary>
        /// <param name="pSub">SunCategory ID</param>
        /// <param name="pCount">Döndürülecek site sayısı</param>
        /// <returns>List türünde veri döner</returns>
        public List<SearchResult> Select_Best_Sites_To_Sub(string pSub, int pCount)
        {
            return base.SiteOperationDalObject.Select_Best_Sites_To_Sub(pSub, pCount);
        }

        /// <summary>
        /// Parametrede gelen Category Türünde en ok oy alan site lerin bilgilerini SearchResult türünde list olarak döndüren metot Parametrede gelen sayı kadarını döndürür
        /// </summary>
        /// <param name="pCat">Category ID</param>
        /// <param name="pCount">Döndürülecek site sayısı</param>
        /// <returns>List türünde veri döner</returns>
        public List<SearchResult> Select_Best_Sites_To_Cat(string pCat, int pCount)
        {
            return base.SiteOperationDalObject.Select_Best_Sites_To_Cat(pCat, pCount);
        }
    }
}

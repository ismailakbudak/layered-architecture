using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
   public class ImageOperationBL : Base
    {
       /// <summary>
       /// Parametre ile gelen SiteID li sitenin Resimlerini döndüren metot
       /// </summary>
       /// <param name="SiteID">IMAGE SiteID</param>
       /// <returns> List<IMAGE> tipinde veri döner </returns>
        public List<IMAGE> get_Image(int SiteID)
        {
            return base.ImageOperationDalObject.get_Image(SiteID);
        }

       /// <summary>
       /// IMAGE tablosuna yeni image ekleyen metot
       /// </summary>
       /// <param name="value">IMAGE tipinde parametre</param>
       /// <returns>Eklenirse TRUE eklenemezse FALSE</returns>
        public bool add_Image(IMAGE value)
        {
            return base.ImageOperationDalObject.add_Image(value);
        }

       /// <summary>
       /// Parametrede gelen SiteID li Sitenin Resimlerini Silen metot
       /// </summary>
       /// <param name="SiteID">IMAGE SiteID</param>
       /// <returns>Silinirse True silinemezse FALSE döner</returns>
        public bool delete_Image(int SiteID)
        {
            return base.ImageOperationDalObject.delete_Image(SiteID);
        }
       /// <summary>
       /// Bu fonksiyon ID si verilen sitenin İlk imajını alır
       /// </summary>
       /// <param name="pSiteID"></param>
       /// <returns></returns>
        public IMAGE get_this_website(int pSiteID)
        {
            return base.ImageOperationDalObject.get_this_website(pSiteID);
        }

    }
}

using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
    public class CommentsOperationBL : Base
    {
        /// <summary>
        ///  Parametre İle gelen SiteID li sitenin yorumlerını döndüren metot
        /// </summary>
        /// <param name="SiteID">COMMENTS SiteID</param>
        /// <returns>List<COMMENTS> List tipinde Veri</returns>
        public List<COMMENTS> get_SiteComments(int SiteID)
        {
            return base.CommentsOperationDalObject.get_SiteComments(SiteID);
        }

        /// <summary>
        ///  COMMENTS tablosuna parametre ile gelen veriyi ekleyen metot
        /// </summary>
        /// <param name="value">COMMENTS tipinde parametre</param>
        /// <returns>Eklenirse TRUE eklenemezse FALSE döner</returns>
        public bool add_Comments(COMMENTS value)
        {
            return base.CommentsOperationDalObject.add_Comments(value);
        }

        /// <summary>
        /// Parametre ile gelen ID li COMMENTS i silen metot
        /// </summary>
        /// <param name="ID">COMMENTS ID</param>
        /// <returns> Silinirse TRUE silinemezse FALSE döner</returns>
        public bool delete_Comments(int ID)
        {
            return base.CommentsOperationDalObject.delete_Comments(ID);
        }

        /// <summary>
        ///  CommentsInfo sınıfı türünde list olarak sitenin yorumlarını çeker
        /// </summary>
        /// <param name="_SiteID">SiteID </param>
        /// <returns>List şeklinde veri döner</returns>
        public List<CommentsInfo> Get_Site_Comments_Spesific(string _SiteID)
        {
            return base.CommentsOperationDalObject.Get_Site_Comments_Spesific(_SiteID);
        }
    }
}

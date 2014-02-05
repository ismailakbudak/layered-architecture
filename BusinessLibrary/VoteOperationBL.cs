using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
    public class VoteOperationBL : Base
    {
        /// <summary>
        /// SiteID'ye göre Siteleri List Şeklinde döndüren metot
        /// </summary>
        /// <param name="SiteID">VOTE SiteID</param>
        /// <returns>List<VOTE> list tipinde veri döndürür</returns>
        public List<VOTE> get_SiteVotes(int SiteID)
        {
            return base.VoteOperationDalObject.get_SiteVotes(SiteID);
        }

        /// <summary>
        /// Yeni VOTE ekleyen metot
        /// </summary>
        /// <param name="value">VOTE tipinde parametre gerekli</param>
        /// <returns>Eklenirse TRUE eklenemezse FALSE</returns>
        public bool add_Vote(VOTE value)
        {
            return base.VoteOperationDalObject.add_Vote(value);
        }

        /// <summary>
        ///  Parametrede gelen SiteID için verilen oy sayısını döndürür
        /// </summary>
        /// <param name="pSiteID">Site ID</param>
        /// <returns></returns>
        public VoteInfo get_SiteVotes_Count(int pSiteID)
        {
            return base.VoteOperationDalObject.get_SiteVotes_Count( pSiteID);
        }

     
        /// <summary>
        ///  Kullanıcının oy verip vermediğini kontrol eden metot
        /// </summary>
        /// <param name="pUserID">UserID    </param>
        /// <param name="_SiteID">SiteID</param>
        /// <returns>Boool değer</returns>
        public bool Kullanici_Oyu(int pUserID, int _SiteID)
        {
            return base.VoteOperationDalObject.Kullanici_Oyu(pUserID, _SiteID);
        }
    }
}

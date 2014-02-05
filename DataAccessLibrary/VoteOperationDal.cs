using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class VoteOperationDal : Base
    {
        public List<VOTE> get_SiteVotes(int SiteID)
        {
            var result = (from inc in base.DbObject.VOTE where inc.SiteID == SiteID select inc).ToList();
            return result;
        }

        public bool add_Vote(VOTE value)
        {
            bool result = false;
            try
            {
                base.DbObject.VOTE.Add(value);
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public VoteInfo get_SiteVotes_Count(int pSiteID)
        {
            VoteInfo value = new VoteInfo();

            // Oy veren sayısnı döndürür
            var result = (from inc in DbObject.VOTE
                          where inc.SiteID == pSiteID
                          select inc).ToList().Count.ToString();

            // 1  oy dan başlayarak 5 e kadar kaç kişi oy vermiş
            var result1 = base.DbObject.VOTE.Where(c => c.Value == 1 && c.SiteID == pSiteID).ToList().Count.ToString();
            var result2 = base.DbObject.VOTE.Where(c => c.Value == 2 && c.SiteID == pSiteID).ToList().Count.ToString();
            var result3 = base.DbObject.VOTE.Where(c => c.Value == 3 && c.SiteID == pSiteID).ToList().Count.ToString();
            var result4 = base.DbObject.VOTE.Where(c => c.Value == 4 && c.SiteID == pSiteID).ToList().Count.ToString();
            var result5 = base.DbObject.VOTE.Where(c => c.Value == 5 && c.SiteID == pSiteID).ToList().Count.ToString();

            // Oy ortalaması
            var resultOrtalama = base.DbObject.Database.SqlQuery<string>("select  CONVERT(varchar, AVG(Value)) as sayi from VOTE where SiteID = " + pSiteID).FirstOrDefault();

            if (resultOrtalama != null)
               value.Vote = resultOrtalama;
            else
               value.Vote = "0";

            value.Count = result;
            value.Vote1 = result1;
            value.Vote2 = result2;
            value.Vote3 = result3;
            value.Vote4 = result4;
            value.Vote5 = result5;

            return value;
        }

        public bool Kullanici_Oyu(int pUserID, int _SiteID)
        {
            var result = base.DbObject.VOTE.Where(c => c.SiteID == _SiteID && c.VoterID == pUserID).FirstOrDefault();
        
            if (result != null)
                return false;

            else
                return true;
        }
    }
}

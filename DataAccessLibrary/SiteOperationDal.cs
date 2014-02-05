using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class SiteOperationDal :Base
    {
        public bool add_Site(SITE value)
        {
            bool result = false;
            try
            {
                base.DbObject.SITE.Add(value);
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public List<SITE> GetAll_Site()
        {
            List<SITE> siteler;
            try
            {
                siteler = base.DbObject.SITE.Where(c => c.Status == 0).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }           

            return siteler;
        }
      
        public bool update_Site()
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

        public bool delete_Site(int ID)
        {
          
            bool result = false;
            try
            {
                // Sitenin fotolarının silinmesi
                var result2 = base.DbObject.IMAGE.Where(c => c.SiteID == ID).ToList();
                foreach (var item in result2)
                {
                    base.DbObject.IMAGE.Remove(item);
                }

                // Site için yapılan yorumların silinmesi
               var result3 = base.DbObject.COMMENTS.Where(c => c.SiteID == ID).ToList();
               foreach (var item in result3)
               {
                   base.DbObject.COMMENTS.Remove(item);
               }

                // Sitenin Oylarının silinmesi
               var result4 = base.DbObject.VOTE.Where(c => c.SiteID == ID).ToList();
               foreach (var item in result4)
               {
                   base.DbObject.VOTE.Remove(item);
               }

                // sitenin kendisinin silinmesi
                var result1 = (from inc in base.DbObject.SITE
                               where inc.ID == ID
                               select inc).FirstOrDefault();
                base.DbObject.SITE.Remove(result1);
                base.DbObject.SaveChanges();

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public int onaybekleyensiteler()
        {
            return base.DbObject.SITE.Where(c => c.Status == 0).Count();
        }

        public SITE Get_This_WebSite(int id)
        {
            SITE busite;
            try
            {
                busite = base.DbObject.SITE.Where(c => c.ID == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
            return busite;
        }

        public bool Site_Onayla(int id)
        {
            bool result = false;
            try
            {
                SITE site = Get_This_WebSite(id);
                site.Status = 1;
                update_Site();
                result = true;
            }
            catch (Exception)
            {
                return false;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pUserID"></param>
        /// <returns></returns>
        public List<SITE> Get_Site(int pUserID)
        {
            var result = base.DbObject.SITE.Where(c => c.UserID == pUserID).ToList();
            return result;
        }

        public List<SiteUserInfo> Get_Site_Info(int pUserID)
        {
            var result = (from site in base.DbObject.SITE
                          join category in base.DbObject.SUB_CATEGORY on site.SubCategoryID equals category.ID
                          where site.UserID == pUserID
                          select new SiteUserInfo 
                          {
                             ID = site.ID,
                             SiteName = site.Name,
                             Category = category.SubCategory,
                             InsertDate = site.InsertDate
                          }  ).ToList();
            return result;               
        }

        public SITE Get_Site_Info_By_SiteID(int pSiteID)
        {
            SITE site = base.DbObject.SITE.Where(c => c.ID == pSiteID).FirstOrDefault();
            return site;
        }

        public SITE Get_Site_By_Name(string pSiteName)
        {
            var result = base.DbObject.SITE.Where(c => c.Name.CompareTo(pSiteName) == 0).FirstOrDefault();
            return result;
        }

        /// <summary>
        ///  Bu metot En son eklenen Parametrede Gelen pCount Sitenin Bilgilerini SiteInformation Türünde List olarak döndürür
        /// </summary>
        /// <param name="pCount"> Kaçtane web ssitesinin bilgisi isteniyorsa</param>
        /// <returns>List<SiteInformation> List tütünde veri döner</SiteInformation></returns>
        public List<SiteInformation> Get_Site_Anasayfa(int pCount)
        {
            /// Kaçtane site görüntülenmesi isteniyosa
            var result3 = base.DbObject.SITE.OrderByDescending(c => c.ID).Take(pCount);

            var result = (from p_site in result3
                          join p_user in base.DbObject.USERS on p_site.UserID equals p_user.ID
                          join p_sub_category in base.DbObject.SUB_CATEGORY on p_site.SubCategoryID equals p_sub_category.ID
                          where p_site.Status != 0 && p_site.SubCategoryID > 0
                          select new SiteInformation
                          {
                              SiteID = p_site.ID,
                              SiteName = p_site.Name,
                              InsertDate = p_site.InsertDate,
                              URL = p_site.Url,                             
                              UserNameSurname = p_user.Name + " " + p_user.Surname,
                              Category = p_sub_category.SubCategory
                          }
                          ).ToList();

            foreach (var item in result)
            {
                IMAGE _image = base.DbObject.IMAGE.Where(c => c.SiteID == item.SiteID).FirstOrDefault();
                if (_image != null)
                    item.Image1 = _image.Path;
                else
                    item.Image1 = "Resimyok.png";

                // string yazan yere int32 de gelebilir fakata eğer değer yoksa hata fırlatıyor stringte fırlatmıyor null geliyor
                var result2 = base.DbObject.Database.SqlQuery<string>("select  CONVERT(varchar, AVG(Value)) as sayi from VOTE where SiteID = " + item.SiteID).FirstOrDefault();

                if (result2 != null)
                    item.Vote = result2;
                else
                    item.Vote = "0";
             
            }
            return result;
        }

        /// <summary>
        ///  En cok oy alan site lerin bilgilerini SearchResult türünde list olarak döndüren metot Parametrede gelen sayı kadarını döndürür
        /// </summary>
        /// <param name="pCount"> Kaç site döndürülecek ise onu döndürür</param>
        /// <returns> List türünde veri döner</returns>
        public List<SearchResult> Select_Best_Sites(int pCount)
        {
            // En cook oy alan siteleri bulan sorgu
            var result = base.DbObject.Database.SqlQuery<SiteVoteCount>(" select SiteID, COUNT(SiteID) as Count from VOTE Group by SiteID order by Count desc ").Take(pCount).ToList();

            // En cook oy alan sitelerin SITE tablosundan verilerini çeken kod
            var result2 = (from p_site in result
                          join p_site1 in base.DbObject.SITE on p_site.SiteID equals p_site1.ID
                          where p_site1.Status != 0
                          select new SearchResult
                          {
                              SiteID = p_site1.ID,
                              SiteName = p_site1.Name,
                              URL = p_site1.Url,
                              VoteCount = p_site.Count
                          } ).ToList();

            // Resim yollarını ve oy ortalamasını hesaplayan kod
            foreach (var item in result2)
            {
                IMAGE _image = base.DbObject.IMAGE.Where(c => c.SiteID == item.SiteID).FirstOrDefault();
                if (_image != null)
                    item.Image1 = _image.Path;
                else
                    item.Image1 = "Resimyok.png";

                // string yazan yere int32 de gelebilir fakata eğer değer yoksa hata fırlatıyor stringte fırlatmıyor null geliyor
                var result3 = base.DbObject.Database.SqlQuery<string>("select  CONVERT(varchar, AVG(Value)) as sayi from VOTE where SiteID = " + item.SiteID).FirstOrDefault();

                if (result3 != null)
                    item.Vote = result3;
                else
                    item.Vote = "0";

            }
            return result2;
        }

        /// <summary>
        /// Parametrede gelen SubCategory Türünde en ok oy alan site lerin bilgilerini SearchResult türünde list olarak döndüren metot Parametrede gelen sayı kadarını döndürür
        /// </summary>
        /// <param name="pSub">SunCategory ID</param>
        /// <param name="pCount">Döndürülecek site sayısı</param>
        /// <returns>List türünde veri döner</returns>
        public List<SearchResult> Select_Best_Sites_To_Sub(string pSub, int pCount)
        {
            // En cook oy alan siteleri bulan sorgu
            var result = base.DbObject.Database.SqlQuery<SiteVoteCount>(" select SiteID, COUNT(SiteID) as Count , AVG(Value) As Vote from SITE " + 
                                                                        "  inner join VOTE on SITE.ID = VOTE.SiteID "+  
                                                                        "  where SubCategoryID = "+ pSub +
                                                                        " Group by SiteID order by Count desc ").Take(pCount).ToList();

            // En cook oy alan sitelerin SITE tablosundan verilerini çeken kod
            var result2 = (from p_site in result
                           join p_site1 in base.DbObject.SITE on p_site.SiteID equals p_site1.ID
                           where p_site1.Status != 0
                           select new SearchResult
                           {
                               SiteID = p_site1.ID,
                               SiteName = p_site1.Name,
                               URL = p_site1.Url,
                               Vote = p_site.Vote.ToString(),
                               VoteCount = p_site.Count
                           }).ToList();

            // Resim yollarını ve oy ortalamasını hesaplayan kod
            foreach (var item in result2)
            {
                IMAGE _image = base.DbObject.IMAGE.Where(c => c.SiteID == item.SiteID).FirstOrDefault();
                if (_image != null)
                    item.Image1 = _image.Path;
                else
                    item.Image1 = "Resimyok.png";

                if (item.Vote == null)
                    item.Vote = "0";

            }
            return result2;
        }

        /// <summary>
        /// Parametrede gelen Category Türünde en ok oy alan site lerin bilgilerini SearchResult türünde list olarak döndüren metot Parametrede gelen sayı kadarını döndürür
        /// </summary>
        /// <param name="pCat">Category ID</param>
        /// <param name="pCount">Döndürülecek site sayısı</param>
        /// <returns>List türünde veri döner</returns>
        public List<SearchResult> Select_Best_Sites_To_Cat(string pCat, int pCount)
        {
            var result = base.DbObject.Database.SqlQuery<SiteVoteCount>(" select SiteID , COUNT(SiteID) as Count, AVG(Value) as Vote from SITE " +
                                                                        " inner join VOTE on VOTE.SiteID = SITE.ID " +
                                                                        " inner join SUB_CATEGORY on SITE.SubCategoryID = SUB_CATEGORY.ID " +
                                                                        " inner join CATEGORY on CATEGORY.ID = SUB_CATEGORY.CategoryID  " +
                                                                        " where CATEGORY.ID = " + pCat +
                                                                        " Group by SiteID " +
                                                                        " order by Count desc ").ToList().Take(pCount);
         
            // En cook oy alan sitelerin SITE tablosundan verilerini çeken kod
            var result2 = (from p_site in result
                           join p_site1 in base.DbObject.SITE on p_site.SiteID equals p_site1.ID
                           where p_site1.Status != 0
                           select new SearchResult
                           {
                               SiteID = p_site1.ID,
                               SiteName = p_site1.Name,
                               URL = p_site1.Url,
                               Vote = p_site.Vote.ToString(),
                               VoteCount = p_site.Count
                           }).ToList();

            // Resim yollarını ve oy ortalamasını hesaplayan kod
            foreach (var item in result2)
            {
                IMAGE _image = base.DbObject.IMAGE.Where(c => c.SiteID == item.SiteID).FirstOrDefault();
                if (_image != null)
                    item.Image1 = _image.Path;
                else
                    item.Image1 = "Resimyok.png";

                if (item.Vote == null)
                    item.Vote = "0";

            }
            return result2;
        }
    }
}

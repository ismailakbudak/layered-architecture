using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public  class ImageOperationDal : Base
    {
        public List<IMAGE> get_Image(int SiteID)
        {
            var result = (from inc in base.DbObject.IMAGE where inc.SiteID == SiteID select inc).ToList();
            return result;
        }
        //todo aslında bu fonksiyon sitenin son görüntüsünü alması gerekiyor.
        public IMAGE get_this_website(int pSiteID)
        {
            return base.DbObject.IMAGE.Where(c => c.SiteID == pSiteID).FirstOrDefault();
        }
        public bool add_Image(IMAGE value)
        {
            bool result = false;
            try
            {
                base.DbObject.IMAGE.Add(value);
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool delete_Image(int SiteID)
        {
            bool result = false;
            try
            {
                var result1 = (from inc in base.DbObject.IMAGE where inc.SiteID == SiteID select inc).ToList();
                foreach (var item in result1)
                {
                    DbObject.IMAGE.Remove(item);
                    DbObject.SaveChanges();
                }
                DbObject.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}

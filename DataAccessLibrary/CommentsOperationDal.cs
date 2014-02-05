using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class CommentsOperationDal : Base
    {
        public List<COMMENTS> get_SiteComments(int SiteID)
        {
            var result = (from inc in base.DbObject.COMMENTS
                          where inc.SiteID == SiteID
                          select inc).ToList();
            return result;
        }

        public List<COMMENTS> take_only(int adet)
        {
            return base.DbObject.COMMENTS.Take(adet).ToList();
        }

        public bool add_Comments(COMMENTS value)
        {
            bool result = false;
            try
            {
                base.DbObject.COMMENTS.Add(value);
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool delete_Comments(int ID)
        {
            bool result = false;
            try
            {
                var result1 = (from inc in base.DbObject.COMMENTS where inc.ID == ID select inc).FirstOrDefault();
                base.DbObject.COMMENTS.Remove(result1);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public List<CommentsInfo> Get_Site_Comments_Spesific(string _SiteID)
        {
            var result = base.DbObject.Database.SqlQuery<CommentsInfo>(" Select Name as UserName, Date , Comment from COMMENTS  " +
                                      " inner join USERS on USERS.ID = COMMENTS.SenderID  where SiteID = " + _SiteID +" order by COMMENTS.ID desc " ).ToList();

            return result;


        }
    }
}

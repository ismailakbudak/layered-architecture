using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class UserGroupsOperationDal : Base
    {
        public List<USER_GROUPS> get_All_UserGroups()
        {
            var result = (from inc in base.DbObject.USER_GROUPS select inc).ToList();
            return result;
        }
        

        public bool add_UserGroups(USER_GROUPS value)
        {
            bool result = false;
            try
            {
                base.DbObject.USER_GROUPS.Add(value);
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool delete_UserGroups(int ID)
        {
            bool result = false;
            try
            {
                var result1 = (from inc in base.DbObject.USER_GROUPS where inc.ID == ID select inc).FirstOrDefault();
                base.DbObject.USER_GROUPS.Remove(result1);
                base.DbObject.SaveChanges();
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

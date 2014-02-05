using Container;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class CategoryOperationDal : Base
    {

        public CATEGORY get(string name)
        {
            CATEGORY denem = base.DbObject.Database.SqlQuery<CATEGORY>("select * from CATEGORY where CategoryName = '"+name+"'").FirstOrDefault();
            return denem;                                            
        }

        public List<CATEGORY> get_All_Category()
        {
            var result = (from inc in base.DbObject.CATEGORY
                          select inc).ToList();

            return result;
        }

        public bool add_Category(CATEGORY value)
        {
            bool result = false;
            try
            {
                base.DbObject.CATEGORY.Add(value);
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool update_Category()
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

        public bool delete_Category(int ID)
        {
            bool result = false;
            try
            {
                var result1 = (from inc in base.DbObject.CATEGORY
                              where inc.ID == ID
                              select inc).FirstOrDefault();


                base.DbObject.CATEGORY.Remove(result1);
                base.DbObject.SaveChanges();

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
           
        }

        public bool delete_Category(string name)
        {
            bool result = false;
            try
            {
                var result1 = (from inc in base.DbObject.CATEGORY
                               where inc.CategoryName == name
                               select inc).FirstOrDefault();


                base.DbObject.CATEGORY.Remove(result1);
                base.DbObject.SaveChanges();

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }
        public bool isExist(string name)
        {
            bool result = false;
            try
            {
                var result1 = base.DbObject.CATEGORY.Where(c => c.CategoryName.Equals(name)).Count();
                if (result1 > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }

        public CATEGORY get_This_category(int id)
        {
            CATEGORY kategori;
            try
            {
                kategori = base.DbObject.CATEGORY.Where(c => c.ID == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
            return kategori;
        }
    }

}
 
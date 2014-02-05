using Container;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class SubCategoryOperationDal : Base
    {
        public List<SUB_CATEGORY> get_All_SubCategory()
        {
            var result = (from inc in base.DbObject.SUB_CATEGORY select inc).ToList();
            return result;
           
        }

        public List<SUB_CATEGORY> get_spesific_SUBCategory(int id)
        {
            var result = (from inc in base.DbObject.SUB_CATEGORY where inc.CategoryID==id select inc).ToList();
            return result;

        }

        public SUB_CATEGORY get_SubCategory(int id)
        {
            var result = base.DbObject.SUB_CATEGORY.Where(c => c.ID == id).FirstOrDefault();
            return result;

        }
        public bool add_SubCategory(SUB_CATEGORY value)
        {
            bool result = false;
            try
            {
                base.DbObject.SUB_CATEGORY.Add(value);
                base.DbObject.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool delete_SubCategory(int ID)
        {
            bool result = false;
            try
            {
                var result1 = (from inc in base.DbObject.SUB_CATEGORY
                               where inc.ID == ID
                               select inc).FirstOrDefault();


                base.DbObject.SUB_CATEGORY.Remove(result1);
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
                int result1 = base.DbObject.SUB_CATEGORY.Where(c => c.SubCategory.CompareTo(name) == 0).Count();
                if (result1 > 0)
                {
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }


        public string get_spesific_SUBCategory_By_Name(string pSubCategory)
        {
            var result = base.DbObject.SUB_CATEGORY.Where(c => c.SubCategory.CompareTo(pSubCategory).Equals(0)).FirstOrDefault();
         
            if (result != null)
                return result.ID.ToString();
            else
                return null;
        }
    }
}

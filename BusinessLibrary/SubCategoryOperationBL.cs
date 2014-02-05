using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
    public class SubCategoryOperationBL : Base
    {
        /// <summary>
        ///  Bütün SUB_CATEGORY'leri döndüren metot
        /// </summary>
        /// <returns>List<SUB_CATEGORY> list tipinde veri</returns>
        public List<SUB_CATEGORY> get_All_SubCategory()
        {
            return base.SubCategoryOperationDalObject.get_All_SubCategory();
        }

        /// <summary>
        ///  Yeni SUB_CATEGORY Ekleyen metot
        /// </summary>
        /// <param name="value">SUB_CATEGORY tipinde parametre</param>
        /// <returns> Eklenirse TRUE eklenemezse FALSE </returns>
        public bool add_SubCategory(SUB_CATEGORY value)
        {
            return base.SubCategoryOperationDalObject.add_SubCategory(value);
        }

        /// <summary>
        /// Parametre ile Gelen ID'li SUB_CATEGORY'i silen metot
        /// </summary>
        /// <param name="ID">SUB_CATEGORY int ID</param>
        /// <returns>silirse TRUE silinemezse FALSE </returns>
        public bool delete_SubCategory(int ID)
        {
            return base.SubCategoryOperationDalObject.delete_SubCategory(ID);
        }

        /// <summary>
        ///  Parametre ile CategoryID'li SUB_CATEGORY 'leri List döndüren metot
        /// </summary>
        /// <param name="pCategoryID">SUB_CATEGORY CategoryID  </param>
        /// <returns>List<SUB_CATEGORY> list döner</SUB_CATEGORY></returns>
        public List<SUB_CATEGORY> get_spesific_SUBCategory(int pCategoryID)
        {
            return base.SubCategoryOperationDalObject.get_spesific_SUBCategory(pCategoryID);

        }
        /// <summary>
        /// İd'si verilen SubCategory yi döndürecektir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SUB_CATEGORY get_SubCategory(int id)
        {
            return base.SubCategoryOperationDalObject.get_SubCategory(id);
        }

        /// <summary>
        /// name isimli subcategory var mı yok mu onu döndürecek
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool isExist(string name)
        {
            return base.SubCategoryOperationDalObject.isExist(name);
        }

        /// <summary>
        ///  Parametre gelen SubCategory isimli Alt kategorinin ID sini döndürür
        /// </summary>
        /// <param name="pSubCategory">Bir Alt kategori ismi</param>
        /// <returns>string türünde ID döner</returns>
        public string get_spesific_SUBCategory_By_Name(string pSubCategory)
        {
            return base.SubCategoryOperationDalObject.get_spesific_SUBCategory_By_Name(pSubCategory);
        }
    }
}

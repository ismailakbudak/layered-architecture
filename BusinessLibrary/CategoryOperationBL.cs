using Container;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
    public class CategoryOperationBL : Base
    {
        /// <summary>
        ///  Parametrede Gelen NAME e göre CATEGORY dödüren metot
        /// </summary>
        /// <param name="name">COMMENTS CategoryName</param>
        /// <returns>CATEGORY tipinde veri döndürür yoksa null</returns>
        public CATEGORY get(string name)
        {
            return base.CategoryOperationDalObject.get(name);
        }

        /// <summary>
        /// List şeklinde tüm CATEGORY leri döndürür
        /// </summary>
        /// <returns>List<CATEGORY> list tipinde veri </returns>
        public List<CATEGORY> get_All_Category()
        {
            return base.CategoryOperationDalObject.get_All_Category();
        }

        /// <summary>
        ///  Yeni CATEGORY ekleyen metot
        /// </summary>
        /// <param name="value">CATEGORY tipinde parametre</param>
        /// <returns>Eklenirse TRUE eklenemezse FALSE</returns>
        public bool add_Category(CATEGORY value)
        {
            return base.CategoryOperationDalObject.add_Category(value);
        }

        /// <summary>
        /// CATEGORY güncelleyen metot
        /// </summary>
        /// <returns>Güncellenirse TRUE güncellenemezse FALSE</returns>
        public bool update_Category()
        {
          return  base.CategoryOperationDalObject.update_Category();
        }

        /// <summary>
        /// Parametrede gelen ID li CATEGORY'i silen metot
        /// </summary>
        /// <param name="ID">CATEGORY ID</param>
        /// <returns>Silinrse TRUE silinemezse FALSE</returns>
        public bool delete_Category(int ID)
        {
            return base.CategoryOperationDalObject.delete_Category(ID);
        }

        /// <summary>
        /// İsme göre CAtegory Silen metot
        /// </summary>
        /// <param name="name">CATEGORY CategoryName</param>
        /// <returns>silinirse TRUE silinemezse FALSE </returns>
        public bool delete_Category(string name)
        {
          return base.CategoryOperationDalObject.delete_Category(name);
        }

        /// <summary>
        /// Bu Fonksiyon "Name" İsimli Kategori Olup Olmadığını Kontrol Ediyor.
        /// </summary>
        /// <param name="name">name:Kategori İsmi</param>
        /// <returns></returns>
        public bool isExist(string name)
        {
            return base.CategoryOperationDalObject.isExist(name);

        }
        /// <summary>
        /// Bu Fonksiyon İd si verilen kategoriyi döndürür
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CATEGORY get_This_category(int id)
        {
            return base.CategoryOperationDalObject.get_This_category(id);
        }

    }
}

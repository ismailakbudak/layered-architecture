using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
    public class UserGroupsOperationBL : Base
    {
        /// <summary>
        /// USER_GROUPS'larını list şeklnde döndüren metot
        /// </summary>
        /// <returns>List<USER_GROUPS> list tipinde veri döner</returns>
        public List<USER_GROUPS> get_All_UserGroups()
        {
            return base.UserGroupsOperationDalObject.get_All_UserGroups();
        }
        /// <summary>
        /// Yeni USER_GROUPS ekleyen metot
        /// </summary>
        /// <param name="value">USER_GROUPS Tipinde paramatre</param>
        /// <returns>Eklenirse TRUE eklenmezse FALSE</returns>
        public bool add_UserGroups(USER_GROUPS value)
        {
            return base.UserGroupsOperationDalObject.add_UserGroups(value);
        }
        /// <summary>
        /// Parametre de gelen ID li VOTE'u silen metot
        /// </summary>
        /// <param name="ID">VOTE ID</param>
        /// <returns>silinirse TRUE silinemezse FALSE</returns>
        public bool delete_UserGroups(int ID)
        {
            return base.UserGroupsOperationDalObject.delete_UserGroups(ID);
        }
    }
}

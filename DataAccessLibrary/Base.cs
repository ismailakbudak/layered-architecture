using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public abstract class Base
    {
        private WEBHOUSEEntities _WebhouseContext = null;

        protected WEBHOUSEEntities DbObject
        {
            get
            {
                if(_WebhouseContext == null)
                    _WebhouseContext=new WEBHOUSEEntities();

                return _WebhouseContext;
            }
        }
    }
}

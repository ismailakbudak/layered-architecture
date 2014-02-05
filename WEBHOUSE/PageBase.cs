
using BusinessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public abstract class PageBase : System.Web.UI.Page
    {
        private CategoryOperationBL _CategoryOp = null;
        protected CategoryOperationBL CategoryOperationObject
        {
            get
            {
                if (_CategoryOp == null)
                    _CategoryOp = new CategoryOperationBL();

                return _CategoryOp;
            }
        }

        private CommentsOperationBL _CommentsOp = null;
        protected CommentsOperationBL CommentsOperationObject
        {
            get
            {
                if (_CommentsOp == null)
                    _CommentsOp = new CommentsOperationBL();

                return _CommentsOp;
            }
        }

      
        
    }
}
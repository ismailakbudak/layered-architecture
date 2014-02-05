using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLibrary
{
    public abstract class Base
    {
        private CategoryOperationDal _CategoryOp = null;
        protected CategoryOperationDal CategoryOperationDalObject
        {
            get
            {
                if (_CategoryOp == null)
                {
                    _CategoryOp = new CategoryOperationDal();
                }
                return _CategoryOp;
            }
        }

        private CommentsOperationDal _CommentsOp = null;
        protected CommentsOperationDal CommentsOperationDalObject
        {
            get 
            {
                if (_CommentsOp == null)
                    _CommentsOp = new CommentsOperationDal();

                return _CommentsOp;
            }
        }

        private ImageOperationDal _ImageOp = null;
        protected ImageOperationDal ImageOperationDalObject
        {
            get
            {
                if (_ImageOp == null)
                    _ImageOp = new ImageOperationDal();
                
                return _ImageOp;
            }
        }

        private SiteOperationDal _SiteOp = null;
        protected SiteOperationDal SiteOperationDalObject
        {
            get
            {
                if (_SiteOp == null)
                    _SiteOp = new SiteOperationDal();

                return _SiteOp;
            }
        }

        private SubCategoryOperationDal _SubCategoryOp = null;
        protected SubCategoryOperationDal SubCategoryOperationDalObject
        {
            get
            {
                if (_SubCategoryOp == null)
                    _SubCategoryOp = new SubCategoryOperationDal();

                return _SubCategoryOp;
            }
        }

        private UserGroupsOperationDal _UserGroupsOp = null;
        protected UserGroupsOperationDal UserGroupsOperationDalObject
        {
            get
            {
                if (_UserGroupsOp == null)
                    _UserGroupsOp = new UserGroupsOperationDal();

                return _UserGroupsOp;
            }
        }

        private UserOperationDal _UserOp = null;
        protected UserOperationDal UserOperationDalObject
        {
            get 
            {
                if (_UserOp == null)
                    _UserOp = new UserOperationDal();

                return _UserOp;
            }
        }

        private VoteOperationDal _VoteOp = null;
        protected VoteOperationDal VoteOperationDalObject
        {
            get
            {
                if (_VoteOp == null)
                    _VoteOp = new VoteOperationDal();

                return _VoteOp;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp;

namespace WebApplication1
{
    public partial class WebForm1 : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCategory.DataSource =  base.CategoryOperationObject.get_All_Category();
            ddlCategory.DataBind();
            txt.Text = base.CategoryOperationObject.get_All_Category().First().CategoryName;
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
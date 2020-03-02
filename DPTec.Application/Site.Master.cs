using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DPTec.Application
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (("Login").Equals(Page.Title))
                Menu.Visible = false;
            else
                Menu.Visible = true;
        }
        protected void logoff_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect($"~/Default.aspx", false);
        }
    }
}
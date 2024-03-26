using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Training
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LoggedIn"] != null && (bool)Session["LoggedIn"])
                {
                    LoggedInPanel.Visible = true;
                    UsernameLabel.Text = Session["Username"].ToString();
                }
                else
                {
                    LoggedInPanel.Visible = false;
                }
            }

        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}
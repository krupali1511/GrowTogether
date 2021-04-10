using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrowTogetherClient
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["userid"].ToString());

        }
        protected void home()
        {
            Response.Redirect("Home.aspx");
        }
        protected void contacctadmin()
        {
            Response.Redirect("Home.aspx");
        }
        protected void about()
        {
            Response.Redirect("Home.aspx");
        }
        protected void profile()
        {
            Response.Redirect("Profile.aspx");
        }

    }
}
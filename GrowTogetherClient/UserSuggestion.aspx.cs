using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrowTogetherClient
{
    public partial class UserSuggestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        void BindGrid()
        {
            profileref.UserProfileServiceClient client = new profileref.UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
            profileref.Message message = new profileref.Message();
            DataSet ds = new DataSet();
            ds = client.GetMessages();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
      

    }
}
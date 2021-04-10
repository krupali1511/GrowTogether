using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrowTogetherClient
{
    public partial class ManageUserClient : System.Web.UI.Page
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
            profileref.UserProfile user = new profileref.UserProfile();
            DataSet ds = new DataSet();
            ds = client.GetUserRecords();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            profileref.UserProfileServiceClient client = new profileref.UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
            profileref.UserProfile user = new profileref.UserProfile();
                
            int ID = (int)e.Keys["UserId"];
            user.UserID = ID;
            client.DeleteRecords(user);

            BindGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddUser.aspx");
        }
    }
}
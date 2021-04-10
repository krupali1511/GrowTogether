using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrowTogetherClient
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            profileref.UserProfileServiceClient client = new profileref.UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
            profileref.UserProfile user = new profileref.UserProfile();
            String username = txt_Username.Text;
            String password = txt_password.Text;
            String error = "";
            user.Username = username;
            user.Password = password;
            if (username == "" || password == "")
            {
                Label2.Text = "Required";
                Label3.Text = "Required";
                Label2.ForeColor = Color.Red;
                Label3.ForeColor = Color.Red;

            }
            else
            {
                DataSet ds = client.Registration(user);
                if (ds != null)
                {
                    Session["userid"] = ds.Tables[0].Rows[0]["UserId"];
                    Response.Redirect("Fileupload.aspx");
                }
                else
                {
                    Label1.Text = "Something went wrong";
                    Label1.ForeColor = Color.Red;
                }
            }
           
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_password.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
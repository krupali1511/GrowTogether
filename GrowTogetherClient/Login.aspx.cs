using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrowTogetherClient
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

   

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            profileref.UserProfileServiceClient client = new profileref.UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
            profileref.UserProfile user = new profileref.UserProfile();
            String username = txt_Username.Text;
            String password = txt_password.Text;
            
            if(username == "admin" && password == "admin")
            {
                Response.Redirect("AdminHome.aspx");
            }
            if (username == "" || password == "")
            {
                Label2.Text = "Required";
                Label3.Text = "Required";
            }
            else
            {
                user.Username = username;
                user.Password = password;
                DataSet ds = client.Login(user);
                
                if (ds.Tables[0].Rows.Count != 0)
                {
                    Session["userid"] = ds.Tables[0].Rows[0]["UserId"];
                    Response.Write(Session["userid"].ToString());
                    Label1.Text = ds.ToString();
                    Response.Redirect("Fileupload.aspx");
                }
                else
                {
                    Label1.Text = "Username or Password is invalid!";

                }
            }
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_Username.Text = "";
            txt_password.Text = "";
        }
    }
}
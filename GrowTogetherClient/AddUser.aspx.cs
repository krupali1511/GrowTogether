using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrowTogetherClient
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            profileref.UserProfileServiceClient client = new profileref.UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
            profileref.UserProfile user = new profileref.UserProfile();
            
            user.Name = TextBox1.Text;
            user.Email = TextBox2.Text;
            user.Gender = TextBox5.Text;
            user.Phone = TextBox4.Text;
            client.AddUserRecord(user);
            Label1.Text = "Success";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrowTogetherClient
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            profileref.UserProfile user = new profileref.UserProfile();
    
        }
      

        protected void Button1_Click(object sender, EventArgs e)
        {
            profileref.UserProfileServiceClient client = new profileref.UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
            profileref.UserProfile user = new profileref.UserProfile();
            user.Email = email.Text;
            user.Name = txt_name.Text;
            user.Phone = phone.Text;
            user.Username = txt_Username.Text;
            user.Gender = gender.SelectedItem.Value.ToString();
            user.UserID = (int)Session["userid"];
            string msg = client.UpdateUserContact(user);
            Label1.Text = msg;
            Label1.ForeColor = Color.Green;
        }
    }
}
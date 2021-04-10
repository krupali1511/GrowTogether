using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GrowTogetherClient
{
    public partial class ContactAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Message_Click(object sender, EventArgs e)
        {
            profileref.UserProfileServiceClient client = new profileref.UserProfileServiceClient("BasicHttpBinding_IUserProfileService");
            profileref.Message message = new profileref.Message();
            profileref.UserProfile user = new profileref.UserProfile();
            string des = msgdes.Text;
            string sub = msgsub.Text;
            if(des == "" || sub == "")
            {
                Label2.Text = "Required";
                Label3.Text = "Required";
                Label2.ForeColor = Color.Red;
                Label3.ForeColor = Color.Red;

            }
            else
            {
                message.Msgdes = msgdes.Text;
                message.Msgsub = msgsub.Text;
                user.UserID = (int)Session["userid"];
                string result = client.SendRequest(user, message);
                Label3.Text = result;
                Label3.ForeColor = Color.Green;

            }


        }
    }
}
using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreelanceClient
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceReference1.UserServiceClient client = new ServiceReference1.UserServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            if(user!=null)
                Response.Write("Welcome: "+user.Username);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User user;
            user = client.Login(username.Text, password.Text);
            msg.ForeColor = System.Drawing.Color.Green;
            if (user == null || user.Name=="Error")
            {
                msg.Text = "Error";
                msg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                msg.Text = "Successfully LoggedIn";
                Session["User"] = user;
            }
        }
    }
}
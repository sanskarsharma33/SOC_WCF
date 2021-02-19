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
            User user;
            user = client.Login("sanskar", "sar");
            if (user == null)
                Label1.Text = "Error";
            else
                Label1.Text = user.Username;
        }
    }
}
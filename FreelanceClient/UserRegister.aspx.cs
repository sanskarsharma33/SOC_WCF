using FreelanceClient.ServiceReference1;
using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreelanceClient
{
    public partial class UserRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.UserServiceClient client = new ServiceReference1.UserServiceClient();
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.Username = "Sanskar";
                user.Password = "Sanskar";
                user.Name = "Sanskar";
                user.Phone = "7802853014";
                user.IsFreelancer = true;
                user.DateOfBirth = DateTime.Now;
                user.Details = "HII";
                user.Email = "Sanskar@gmail.com";
                user.Gender = "Male";
                string msg = client.CreateUser(user);
                Label1.Text = msg;
            }
            catch (Exception ex)
            {
                string msg = "ClientError";
                Label1.Text = msg;
            }
        }
    }
}
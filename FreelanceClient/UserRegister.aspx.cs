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
        String Gender;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.UserServiceClient client = new ServiceReference1.UserServiceClient();
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.Username = username.Text;
                user.Password = password.Text;
                user.Name = name.Text;
                user.Phone = phone.Text;
                user.IsFreelancer = true;   
                user.DateOfBirth = dob.SelectedDate;
                user.Details = usrDescription.Text;
                user.Email = EmailID.Text;
                if(RadioButton1.Checked)
                    user.Gender = "Male";
                else if(RadioButton2.Checked)
                    user.Gender = "Female";
                string res = client.CreateUser(user);
                msg.Text = res;
                if(res!="Error")
                    msg.ForeColor = System.Drawing.Color.Green;
                else
                    msg.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                string res = "ClientError";
                msg.Text = ex.Message;
                msg.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        
    }
}
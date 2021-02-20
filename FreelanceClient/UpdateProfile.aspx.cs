using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreelanceClient
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (User)Session["User"];
            if (user == null)
                Response.Redirect("Login.aspx");
            if (username.Text != user.Username)
            {
                username.Text = user.Username;
                name.Text = user.Name;
                phone.Text = user.Phone;
                dob.SelectedDate = user.DateOfBirth;
                usrDescription.Text = user.Details;
                EmailID.Text = user.Email;
            }

        }
        ServiceReference1.UserServiceClient client = new ServiceReference1.UserServiceClient();

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                user.Username = username.Text;
                user.Name = name.Text;
                user.Phone = phone.Text;
                user.DateOfBirth = dob.SelectedDate;
                user.Details = usrDescription.Text;
                user.Email = EmailID.Text;
                if (RadioButton1.Checked)
                    user.Gender = "Male";
                else if (RadioButton2.Checked)
                    user.Gender = "Female";
                string res = client.UpdateUser(user);
                msg.Text = res;
                if (res != "Error")
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
    }
}
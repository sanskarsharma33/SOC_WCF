using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreelanceClient
{
    public partial class AddProjectRequest : System.Web.UI.Page
    {
        ProjectRequestServiceRef.ProjectRequestServiceClient client = new ProjectRequestServiceRef.ProjectRequestServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            if (user == null)
                Response.Redirect("Login.aspx");
            FreelancerId.Text = user.Id.ToString();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectRequest pr = new ProjectRequest();
                pr.Bid = int.Parse(Bid.Text);
                pr.Deadline = DateTime.Parse(Deadline.Text);
                pr.FreelancerId = int.Parse(FreelancerId.Text);
                pr.ProjectId = int.Parse(DropDownList1.SelectedValue);
                pr.Note = Note.Text;
                string res = client.AddProjectRequest(pr);
                if (res != "Error")
                    Response.Redirect("Login.aspx");
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
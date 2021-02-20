using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FreelanceService.ModelClasses;

namespace FreelanceClient
{
    public partial class ViewProjectRequest : System.Web.UI.Page
    {
        ProjectRequestServiceRef.ProjectRequestServiceClient client = new ProjectRequestServiceRef.ProjectRequestServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            if (user == null)
                Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ProjectRequest pr = client.ViewProjectRequest(int.Parse(prId.Text.ToString()));
            freelancer.Text = pr.FreelancerId.ToString();
            project.Text = pr.ProjectId.ToString();
            note.Text = pr.Note.ToString();
            bid.Text = pr.Bid.ToString();
        }
    }
}
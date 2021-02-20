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
    public partial class ShowProjectRequest : System.Web.UI.Page
    {
        ProjectServiceRef.ProjectServiceClient client1 = new ProjectServiceRef.ProjectServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            if (user == null)
                Response.Redirect("Login.aspx");
            DataTable dt = client1.GetProjects();
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }

        ProjectRequestServiceRef.ProjectRequestServiceClient client = new ProjectRequestServiceRef.ProjectRequestServiceClient();
        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = client.ShowProjectRequests(int.Parse(pId.Text));
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
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
    public partial class AllProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            if (user == null)
                Response.Redirect("Login.aspx");
            ownerId.Text = user.Id.ToString();
        }

        ProjectServiceRef.ProjectServiceClient client = new ProjectServiceRef.ProjectServiceClient();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Project pr = new Project();
            pr.OwnerId = int.Parse(ownerId.Text);
            pr.Type = type.Text;
            pr.Details = details.Text;
            pr.Title = title.Text;
            pr.Deadline = DateTime.Parse(deadline.Text);
            pr.Budget = int.Parse(budget.Text);

            if (RadioButton1.Checked)
            {
                pr.IsOpen = true;
            }
            else
            {
                pr.IsOpen = false;
            }

            string r = client.AddProject(pr);
            msg.Text = r.ToString();
            msg.ForeColor = System.Drawing.Color.Green;
            if (r == "Failed to delete")
                msg.ForeColor = System.Drawing.Color.Red;
            pId.Text = "";
            ownerId.Text = "";
            type.Text = "";
            details.Text = "";
            title.Text = "";
            budget.Text = "";
            deadline.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataTable dt = client.GetProjects();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProject.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Project dpr = new Project();
            dpr.Id = int.Parse(pId.Text);
            string res = client.DeleteProject(dpr);
            msg.Text = res.ToString();
            pId.Text = "";
        }
    }
}
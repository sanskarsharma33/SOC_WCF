using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreelanceClient
{
    public partial class UpdateProject : System.Web.UI.Page
    {
        Project tbl = new Project();
        ProjectServiceRef.ProjectServiceClient client = new ProjectServiceRef.ProjectServiceClient();
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            if (user == null)
                Response.Redirect("Login.aspx");
            OwnerId.Text = user.Id.ToString();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {

                tbl.Id = int.Parse(txtSearch.Text.Trim());
                ds = new DataSet();
                ds = client.SearchProject(tbl);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblProjectID.Text = ds.Tables[0].Rows[0]["Id"].ToString();
                    OwnerId.Text = ds.Tables[0].Rows[0]["OwnerId"].ToString();
                    Type.Text = ds.Tables[0].Rows[0]["Type"].ToString();
                    Details.Text = ds.Tables[0].Rows[0]["Details"].ToString();
                    Title.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                    Deadline.Text = ds.Tables[0].Rows[0]["Deadline"].ToString();
                    Budget.Text = ds.Tables[0].Rows[0]["Budget"].ToString();

                    string radio = ds.Tables[0].Rows[0]["IsOpen"].ToString();
                    if (radio == "True")
                    {
                        RadioButton1.Checked = true;
                    }
                    else
                    {
                        RadioButton2.Checked = true;
                    }



                }
                else
                {
                    lblSearchResult.Text = "Please Enter Valid Project ID !";
                    lblSearchResult.ForeColor = System.Drawing.Color.Red;
                }

            }
            else
            {
                lblSearchResult.Text = "Please Enter Employee ID !";
                    lblSearchResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }

        protected void bntUpdated_Click(object sender, EventArgs e)
        {


            tbl.Id = int.Parse(lblProjectID.Text);
            tbl.OwnerId = int.Parse(OwnerId.Text);
            tbl.Type = Type.Text;
            tbl.Details = Details.Text;
            tbl.Title = Title.Text;
            tbl.Deadline = DateTime.Parse(Deadline.Text);
            tbl.Budget = int.Parse(Budget.Text);
            //    tbl.IsOpen =true;
            if (RadioButton1.Checked)
            {
                tbl.IsOpen = true;
            }
            else
            {
                tbl.IsOpen = false;
            }

            string result = client.UpdateProject(tbl);
            lblSearchResult.Text = result;
            lblSearchResult.ForeColor = System.Drawing.Color.Green;

            txtSearch.Text = "";
            lblProjectID.Text = "";
            OwnerId.Text = "";
            Type.Text = "";
            Details.Text = "";
            Title.Text = "";
            Deadline.Text = "";
            Budget.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            // SetPanel(true, false);
            //// txtPhone.Text = "";
            //txtEmail.Text = "";
            // lblEmpID.Text = "";
        }
    }
}
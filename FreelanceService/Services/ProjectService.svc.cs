using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FreelanceService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IProjectService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IProjectService.svc or IProjectService.svc.cs at the Solution Explorer and start debugging.
    public class ProjectService : IProjectService
    {
        public string AddProject(Project pr)
        {
            string msg;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\soc\FreelanceService\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into Project(OwnerId,Type,Details,Title,Deadline,Budget,IsOpen) values(@OwnerId,@Type,@Details,@Title,@Deadline,@Budget,@IsOpen)", con);
            cmd.Parameters.AddWithValue("@OwnerId", pr.OwnerId);
            cmd.Parameters.AddWithValue("@Type", pr.Type);
            cmd.Parameters.AddWithValue("@Details", pr.Details);
            cmd.Parameters.AddWithValue("@Title", pr.Title);
            cmd.Parameters.AddWithValue("@Deadline", pr.Deadline);
            cmd.Parameters.AddWithValue("@Budget", pr.Budget);
            cmd.Parameters.AddWithValue("@IsOpen", pr.IsOpen);

            int g = cmd.ExecuteNonQuery();
            if (g == 1)
            {
                msg = "Successfully inserted";
            }
            else
            {
                msg = "Failed to insert";
            }
            return msg;
        }

        public string DeleteProject(Project pr)
        {
            string msg;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\soc\FreelanceService\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Project where Id=@Id", con);
            cmd.Parameters.AddWithValue("@ID", pr.Id);
            int g = cmd.ExecuteNonQuery();
            if (g == 1)
            {
                msg = "Successfully delted";
            }
            else
            {
                msg = "Failed to delete";
            }
            return msg;
        }

        /*public IEnumerable<Project> GetProjects()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\soc\FreelanceService\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                if (rdr == null)
                {
                    yield break;
                }
                while (rdr.Read())
                {
                    Project proj = new Project();
                    proj.Id = Convert.ToInt32(rdr["Id"].ToString());
                    proj.OwnerId = Convert.ToInt32(rdr["OwnerId"].ToString());
                    proj.Budget = Convert.ToInt32(rdr["Budget"].ToString());
                    proj.Deadline = DateTime.Parse(rdr["Deadline"].ToString());
                    proj.Details = rdr["Details"].ToString();
                    proj.Title = rdr["Title"].ToString();
                    proj.Type = rdr["Type"].ToString();
                    proj.IsOpen = rdr["IsOpen"].ToString() == "True" || rdr["IsOpen"].ToString() == "true";
                    yield return proj;
                }
            }
        }*/

        public DataTable GetProjects()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\soc\FreelanceService\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("ProjectTable");
            da.Fill(dt);
            return dt;
        }

        public DataSet SearchProject(Project proj)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\soc\FreelanceService\App_Data\Database1.mdf;Integrated Security=True");
                string Query = "SELECT * FROM Project WHERE Id=@Id";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Id", proj.Id);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }
        public string UpdateProject(Project pr)
        {
            string msg = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\soc\FreelanceService\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Project set OwnerId=@OwnerId,Type=@Type,Details=@Details,Title=@Title,Deadline=@Deadline,Budget=@Budget,IsOpen=@IsOpen where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", pr.Id);
            cmd.Parameters.AddWithValue("@OwnerId", pr.OwnerId);
            cmd.Parameters.AddWithValue("@Type", pr.Type);
            cmd.Parameters.AddWithValue("@Details", pr.Details);
            cmd.Parameters.AddWithValue("@Title", pr.Title);
            cmd.Parameters.AddWithValue("@Deadline", pr.Deadline);
            cmd.Parameters.AddWithValue("@Budget", pr.Budget);
            cmd.Parameters.AddWithValue("@IsOpen", pr.IsOpen);
            int res = cmd.ExecuteNonQuery();
            if (res == 1)
            {
                msg = "Successfully Updated";
            }
            else
            {
                msg = "Failed to Update";
            }
            return msg;
        }
    }
}

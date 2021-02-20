using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FreelanceService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProjectRequestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProjectRequestService.svc or ProjectRequestService.svc.cs at the Solution Explorer and start debugging.
    public class ProjectRequestService : IProjectRequestService
    {
        public string AddProjectRequest(ProjectRequest projectRequest)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO ProjectRequest (FreelancerId,ProjectId,Deadline,Bid,Note)  
                                               Values(@FreelancerId,@ProjectId,@Deadline,@Bid,@Note)";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@FreelancerId", projectRequest.FreelancerId);
                cmd.Parameters.AddWithValue("@ProjectId", projectRequest.ProjectId);
                cmd.Parameters.AddWithValue("@Deadline", projectRequest.Deadline);
                cmd.Parameters.AddWithValue("@Bid", projectRequest.Bid);
                cmd.Parameters.AddWithValue("@Note", projectRequest.Note);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public string DeleteProjectRequest(int id)
        {

            string msg;
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                SqlCommand cmd = new SqlCommand();

                string Query = @"Delete ProjectRequest where Id=@Id";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                int g = cmd.ExecuteNonQuery();
                if (g == 1)
                {
                    msg = "Successfully delted";
                }
                else
                {
                    msg = "Failed to delete";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msg = "Failed to delete";
            }

            return msg;
        }

        public void DoWork()
        {
        }

        public DataTable ShowProjectRequests(int projectId)
        {
            DataTable dt = new DataTable("projectRequests");

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                SqlCommand cmd = new SqlCommand();

                string Query = @"Select * FROM ProjectRequest where projectId=@ProjectId";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ProjectId", projectId);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }

        public string UpdateProjectRequest(ProjectRequest projectRequest)
        {
            throw new NotImplementedException();
        }

        public ProjectRequest ViewProjectRequest(int id)
        {
            ProjectRequest projectRequest = new ProjectRequest();
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                SqlCommand cmd = new SqlCommand();

                string Query = @"Select * FROM ProjectRequest where Id=@Id";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr != null)
                {
                    projectRequest.Id = Convert.ToInt32(rdr["Id"].ToString());
                    projectRequest.FreelancerId = Convert.ToInt32(rdr["FreelanceId"].ToString());
                    projectRequest.ProjectId = Convert.ToInt32(rdr["ProjectId"].ToString());
                    projectRequest.Deadline = DateTime.Parse(rdr["Deadline"].ToString());
                    projectRequest.Note = rdr["Note"].ToString();
                    projectRequest.Bid = Convert.ToInt32(rdr["Bid"].ToString());

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return projectRequest;
        }
    }
}
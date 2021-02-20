using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FreelanceService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProjectRequestAlloted" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProjectRequestAlloted.svc or ProjectRequestAlloted.svc.cs at the Solution Explorer and start debugging.
    public class ProjectRequestAlloted : IProjectRequestAlloted
    {
        public string AllotProjectRequest(ProjectAlloatted projectAlloated)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO ProjectRequestAllotted (FreelancerId,ProjectId,IsSubmitted)  
                                               Values(@FreelancerId,@ProjectId,@IsSubmitted)";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@FreelancerId", projectAlloated.FreelancerId);
                cmd.Parameters.AddWithValue("@ProjectId", projectAlloated.ProjectId);
                cmd.Parameters.AddWithValue("@IsSubmitted", projectAlloated.IsSubmitted);
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


        public string RemoveAllottedRequest(int id)
        {
            string msg;
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                SqlCommand cmd = new SqlCommand();

                string Query = @"Delete ProjectRequestAllotted where Id=@Id";

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
    }
}
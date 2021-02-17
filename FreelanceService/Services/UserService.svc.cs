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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public DataSet AllUsers()
        {
            throw new NotImplementedException();
        }

        public string CreateUser(User user)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\soc\FreelanceService\App_Data\Database1.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO UserTable (Username,Name,Email,Phone,Gender, Password,DateOfBirth,IsFreelancer,Details)  
                                               Values(@Username,@Name,@Email,@Phone,@Gender, @Password,@DateOfBirth,@IsFreelancer,@Details)";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                cmd.Parameters.AddWithValue("@IsFreelancer", user.IsFreelancer ? 1 : 0);
                cmd.Parameters.AddWithValue("@Details", user.Details);
                Console.WriteLine("HERE");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public DataSet ViewUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}

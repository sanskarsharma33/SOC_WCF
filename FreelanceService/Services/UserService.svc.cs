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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public DataSet AllUsers()
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password)
        {
            User user = new User();
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                SqlCommand cmd = new SqlCommand();

                string Query = @"Select * From UserTable Where Username = @Username and Password = @Password";

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Username", username);
                sda.SelectCommand.Parameters.AddWithValue("@Password", password);
                sda.Fill(ds,"User_table");
                if (ds.Tables[0].Rows[0]["id"] == null)
                    return null;
                user.Id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                user.Username = ds.Tables[0].Rows[0]["Username"].ToString();
                user.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                user.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                user.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                user.Gender = ds.Tables[0].Rows[0]["Gender"].ToString();
                user.Details = ds.Tables[0].Rows[0]["Details"].ToString();
                user.DateOfBirth = DateTime.Parse(ds.Tables[0].Rows[0]["DateOfBirth"].ToString());
                user.IsFreelancer = (ds.Tables[0].Rows[0]["IsFreelancer"].ToString()=="True" || ds.Tables[0].Rows[0]["IsFreelancer"].ToString() == "true");
            }
            catch (Exception ex)
            {
                user.Name = ex.Message;
                return user;
            }
            return user;
        }

        public string CreateUser(User user)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
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

        public string UpdateUser(User user)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                SqlCommand cmd = new SqlCommand();

                string Query = @"Update UserTable set Username=@Username,Name=@Name
                                    ,Email=@Email,Phone=@Phone,Gender=@Gender,DateOfBirth=@DateOfBirth,
                                        IsFreelancer=@IsFreelancer,Details=@Details  Where Id=@Id";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                cmd.Parameters.AddWithValue("@IsFreelancer", user.IsFreelancer ? 1 : 0);
                cmd.Parameters.AddWithValue("@Details", user.Details);
                Console.WriteLine("HERE");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Updated Successfully !";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}

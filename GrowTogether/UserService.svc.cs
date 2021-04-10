using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GrowTogether
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IUserProfile
    {
       
            public string GetData(int value)
            {
                return string.Format("You entered: {0}", value);
            }

            //C- Add Employee Record  
            public string AddUserRecord(User user)
            {
                string result = "";
                try
                {

                    SqlConnection con = new SqlConnection("Data Source=MCNDESKTOP35\\SQLEXPRESS;Initial Catalog=EmployeeDb;User ID=sa;Password=Password$2;");
                    SqlCommand cmd = new SqlCommand();

                    string Query = @"INSERT INTO tblEmployee (UserID,Name,Email,Phone,Gender)  
                                               Values(@UserID,@Name,@Email,@Phone,@Gender)";

                    cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@Gender", user.Gender);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    result = "Record Added Successfully !";
                }
                catch (FaultException fex)
                {
                    result = "Error";
                }

                return result;
            }

            //Retrieve Data  
            //Retrive Record  
            public DataSet GetUserRecords()
            {
                DataSet ds = new DataSet();
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=MCNDESKTOP35\\SQLEXPRESS;Initial Catalog=EmployeeDb;User ID=sa;Password=Password$2;");
                    string Query = "SELECT * FROM tblEmployee";

                    SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                    sda.Fill(ds);
                }
                catch (FaultException fex)
                {
                    throw new FaultException<string>("Error: " + fex);
                }

                return ds;
            }

            //Delete Record  
            public string DeleteRecords(User user)
            {
                string result = "";
                SqlConnection con = new SqlConnection("Data Source=MCNDESKTOP35\\SQLEXPRESS;Initial Catalog=EmployeeDb;User ID=sa;Password=Password$2;");
                SqlCommand cmd = new SqlCommand();
                string Query = "DELETE FROM tblEmployee Where UserID=@UserID";
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Deleted Successfully!";
                return result;
            }

            //Search Employee Record  
            public DataSet SearchUserRecord(User user)
            {
                DataSet ds = new DataSet();
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=MCNDESKTOP35\\SQLEXPRESS;Initial Catalog=EmployeeDb;User ID=sa;Password=Password$2;");
                    string Query = "SELECT * FROM tblEmployee WHERE UserID=@UserID";

                    SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                    sda.SelectCommand.Parameters.AddWithValue("@UserID", user.UserID);
                    sda.Fill(ds);
                }
                catch (FaultException fex)
                {
                    throw new FaultException<string>("Error:  " + fex);
                }
                return ds;
            }

            //UPDATE RECORDS  
            //Update by Phone Roll   
            public string UpdateUserContact(User user)
            {
                string result = "";
                SqlConnection con = new SqlConnection("Data Source=MCNDESKTOP35\\SQLEXPRESS;Initial Catalog=EmployeeDb;User ID=sa;Password=Password$2;");
                SqlCommand cmd = new SqlCommand();

                string Query = "UPDATE tblEmployee SET Email=@Email,Phone=@Phone WHERE UserID=@UserID";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                con.Open();
                cmd.ExecuteNonQuery();
                result = "Record Updated Successfully !";
                con.Close();

                return result;
            }


        }
    }


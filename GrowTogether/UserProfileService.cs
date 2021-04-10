using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SharedLibrary;

namespace GrowTogether
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserProfileService" in both code and config file together.
    public class UserProfileService : IUserProfileService
    {
       
        string connectionString = ConfigurationManager.ConnectionStrings["GT"].ConnectionString;
        //public static object ConfigurationManager { get; private set; }

        public string ConnectionString => connectionString;

        public object WebOperationContext { get; private set; }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //C- Add Employee Record  
        public string AddUserRecord(UserProfile user)
        {
            string result = "";
            try
            {

                SqlConnection con = new SqlConnection(connectionString);
             
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO USERPROFILE (Name,Email,Phone,Gender)  
                                               Values(@Name,@Email,@Phone,@Gender)";

                cmd = new SqlCommand(Query, con);
               // cmd.Parameters.AddWithValue("@UserID", user.UserID);
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
                SqlConnection con = new SqlConnection(connectionString);
                string Query = "SELECT * FROM USERPROFILE";

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
        public string DeleteRecords(UserProfile user)
        {
            string result = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            string Query = "DELETE FROM USERPROFILE Where UserID=@UserID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@UserID", user.UserID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Record Deleted Successfully!";
            return result;
        }
        public DataSet Login(UserProfile user)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                string login = "SELECT * FROM USERPROFILE WHERE Username=@Username AND Password=@Password";
                
                SqlDataAdapter sda = new SqlDataAdapter(login, con);
                sda.SelectCommand.Parameters.AddWithValue("@Username", user.Username);
                sda.SelectCommand.Parameters.AddWithValue("@Password", user.Password);
                sda.Fill(ds);

            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }
        public DataSet Registration(UserProfile user)
        {
            DataSet ds = new DataSet();
            string result = "";
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO USERPROFILE (Username,Password)  
                                               Values(@Username,@Password)";

                cmd = new SqlCommand(Query, con);
                // cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                string login = "SELECT * FROM USERPROFILE WHERE Username=@Username and Password=@Password";
                SqlDataAdapter sda = new SqlDataAdapter(login, con);

                sda.SelectCommand.Parameters.AddWithValue("@Username", user.Username);
                sda.SelectCommand.Parameters.AddWithValue("@Password", user.Password);
                sda.Fill(ds);
                result = "Record Added Successfully !";

            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }
        //Search Employee Record  
        public DataSet SearchUserRecord(UserProfile user)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                string Query = "SELECT * FROM USERPROFILE WHERE UserID=@UserID";

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
        public string UpdateUserContact(UserProfile user)
        {
            string result = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE USERPROFILE SET Name=@Name, Email=@Email,Phone=@Phone,Username=@Username WHERE UserID=@UserID";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@UserID", user.UserID);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Phone", user.Phone);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Username", user.Username);

            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            con.Close();

            return result;
        }

        public string SendRequest(UserProfile user,Message message)
        {
            string result = "";
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO message (msgsubject,msgdes,userID)  
                                               Values(@msgsubject,@msgdes,@UserID)";

                cmd = new SqlCommand(Query, con);
                // cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@msgsubject", message.Msgsub);
                cmd.Parameters.AddWithValue("@msgdes", message.Msgdes);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Message Sent Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }

            return result;
        }

        public DataSet GetMessages()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                string Query = "SELECT * FROM message";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }

        public RemoteFileInfo DownloadFile(DownloadRequest request)
        {
            RemoteFileInfo result = new RemoteFileInfo();
            try
            {
                string filePath = System.IO.Path.Combine(@"c:\Uploadfiles", request.FileName);
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

                // check if exists
                if (!fileInfo.Exists)
                    throw new System.IO.FileNotFoundException("File not found",
                                                              request.FileName);

                // open stream
                System.IO.FileStream stream = new System.IO.FileStream(filePath,
                          System.IO.FileMode.Open, System.IO.FileAccess.Read);

                // return result 
                result.FileName = request.FileName;
                result.Length = fileInfo.Length;
                result.FileByteStream = stream;
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        public void UploadFile(RemoteFileInfo request)
        {
            FileStream targetStream = null;
            Stream sourceStream = request.FileByteStream;

            string uploadFolder = @"C:\upload\";

            string filePath = Path.Combine(uploadFolder, request.FileName);

            using (targetStream = new FileStream(filePath, FileMode.Create,
                                  FileAccess.Write, FileShare.None))
            {
                //read from the input stream in 65000 byte chunks

                const int bufferLen = 65000;
                byte[] buffer = new byte[bufferLen];
                int count = 0;
                while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
                {
                    // save to output stream
                    targetStream.Write(buffer, 0, count);
                }
                targetStream.Close();
                sourceStream.Close();
            }

        }

    }
}

using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GrowTogether
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserProfileService" in both code and config file together.
    [ServiceContract]
    public interface IUserProfileService       
    {
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        DataSet Login(UserProfile user);
        [OperationContract]
        DataSet Registration(UserProfile user);
        [OperationContract]
        string AddUserRecord(UserProfile user);

        [OperationContract]
        DataSet GetUserRecords();

        [OperationContract]
        string DeleteRecords(UserProfile user);

        [OperationContract]
        DataSet SearchUserRecord(UserProfile user);

        [OperationContract]
        string UpdateUserContact(UserProfile user);

        [OperationContract]
        string SendRequest(UserProfile user,Message message);
        [OperationContract]
        DataSet GetMessages();


        [OperationContract]
        RemoteFileInfo DownloadFile(DownloadRequest request);

        [OperationContract]
        void UploadFile(RemoteFileInfo request);

    }
    [MessageContract]
    public class DownloadRequest
    {
        [MessageBodyMember]
        public string FileName;
    }

    [MessageContract]
    public class RemoteFileInfo : IDisposable
    {
        [MessageHeader(MustUnderstand = true)]
        public string FileName;

        [MessageHeader(MustUnderstand = true)]
        public long Length;

        [MessageBodyMember(Order = 1)]
        public System.IO.Stream FileByteStream;

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class UserProfile
    {

        int _userID = 0;
        string _name = "";
        string _email = "";
        string _phone = "";
        string _gender = "";
        string _username = "";
        string _password = "";
        [DataMember]
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        [DataMember]

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        [DataMember]

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }

    [DataContract]
    public class Message
    {
        int _msgID = 0;
        string _msgsub = "";
        string _msgdes = "";

        [DataMember]
        public int MsgId
        {
            get { return _msgID; }
            set { _msgID = value; }
        }
        [DataMember]
        public string Msgsub
        {
            get { return _msgsub; }
            set { _msgsub = value; }
        }
        [DataMember]
        public string Msgdes
        {
            get { return _msgdes; }
            set { _msgdes = value; }
        }
    }
   
}

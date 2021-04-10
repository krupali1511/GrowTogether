using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GrowTogether
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IUserProfile
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string AddUserRecord(User user);

        [OperationContract]
        DataSet GetUserRecords();

        [OperationContract]
        string DeleteRecords(User user);

        [OperationContract]
        DataSet SearchUserRecord(User user);

        [OperationContract]
        string UpdateUserContact(User user);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class User
    {

        string _userID = "";
        string _name = "";
        string _email = "";
        string _phone = "";
        string _gender = "";

        [DataMember]
        public string UserID
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
}  


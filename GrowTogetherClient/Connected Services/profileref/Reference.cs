﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrowTogetherClient.profileref {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserProfile", Namespace="http://schemas.datacontract.org/2004/07/GrowTogether")]
    [System.SerializableAttribute()]
    public partial class UserProfile : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/GrowTogether")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MagIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MsgdesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MsgsubField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MagId {
            get {
                return this.MagIdField;
            }
            set {
                if ((this.MagIdField.Equals(value) != true)) {
                    this.MagIdField = value;
                    this.RaisePropertyChanged("MagId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Msgdes {
            get {
                return this.MsgdesField;
            }
            set {
                if ((object.ReferenceEquals(this.MsgdesField, value) != true)) {
                    this.MsgdesField = value;
                    this.RaisePropertyChanged("Msgdes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Msgsub {
            get {
                return this.MsgsubField;
            }
            set {
                if ((object.ReferenceEquals(this.MsgsubField, value) != true)) {
                    this.MsgsubField = value;
                    this.RaisePropertyChanged("Msgsub");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="profileref.IUserProfileService")]
    public interface IUserProfileService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/GetData", ReplyAction="http://tempuri.org/IUserProfileService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/GetData", ReplyAction="http://tempuri.org/IUserProfileService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/Login", ReplyAction="http://tempuri.org/IUserProfileService/LoginResponse")]
        System.Data.DataSet Login(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/Login", ReplyAction="http://tempuri.org/IUserProfileService/LoginResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> LoginAsync(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/Registration", ReplyAction="http://tempuri.org/IUserProfileService/RegistrationResponse")]
        System.Data.DataSet Registration(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/Registration", ReplyAction="http://tempuri.org/IUserProfileService/RegistrationResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> RegistrationAsync(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/AddUserRecord", ReplyAction="http://tempuri.org/IUserProfileService/AddUserRecordResponse")]
        string AddUserRecord(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/AddUserRecord", ReplyAction="http://tempuri.org/IUserProfileService/AddUserRecordResponse")]
        System.Threading.Tasks.Task<string> AddUserRecordAsync(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/GetUserRecords", ReplyAction="http://tempuri.org/IUserProfileService/GetUserRecordsResponse")]
        System.Data.DataSet GetUserRecords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/GetUserRecords", ReplyAction="http://tempuri.org/IUserProfileService/GetUserRecordsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetUserRecordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/DeleteRecords", ReplyAction="http://tempuri.org/IUserProfileService/DeleteRecordsResponse")]
        string DeleteRecords(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/DeleteRecords", ReplyAction="http://tempuri.org/IUserProfileService/DeleteRecordsResponse")]
        System.Threading.Tasks.Task<string> DeleteRecordsAsync(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/SearchUserRecord", ReplyAction="http://tempuri.org/IUserProfileService/SearchUserRecordResponse")]
        System.Data.DataSet SearchUserRecord(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/SearchUserRecord", ReplyAction="http://tempuri.org/IUserProfileService/SearchUserRecordResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchUserRecordAsync(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/UpdateUserContact", ReplyAction="http://tempuri.org/IUserProfileService/UpdateUserContactResponse")]
        string UpdateUserContact(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/UpdateUserContact", ReplyAction="http://tempuri.org/IUserProfileService/UpdateUserContactResponse")]
        System.Threading.Tasks.Task<string> UpdateUserContactAsync(GrowTogetherClient.profileref.UserProfile user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/SendRequest", ReplyAction="http://tempuri.org/IUserProfileService/SendRequestResponse")]
        string SendRequest(GrowTogetherClient.profileref.UserProfile user, GrowTogetherClient.profileref.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/SendRequest", ReplyAction="http://tempuri.org/IUserProfileService/SendRequestResponse")]
        System.Threading.Tasks.Task<string> SendRequestAsync(GrowTogetherClient.profileref.UserProfile user, GrowTogetherClient.profileref.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/GetMessages", ReplyAction="http://tempuri.org/IUserProfileService/GetMessagesResponse")]
        System.Data.DataSet GetMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserProfileService/GetMessages", ReplyAction="http://tempuri.org/IUserProfileService/GetMessagesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetMessagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserProfileServiceChannel : GrowTogetherClient.profileref.IUserProfileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserProfileServiceClient : System.ServiceModel.ClientBase<GrowTogetherClient.profileref.IUserProfileService>, GrowTogetherClient.profileref.IUserProfileService {
        
        public UserProfileServiceClient() {
        }
        
        public UserProfileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserProfileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserProfileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserProfileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public System.Data.DataSet Login(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.Login(user);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> LoginAsync(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.LoginAsync(user);
        }
        
        public System.Data.DataSet Registration(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.Registration(user);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> RegistrationAsync(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.RegistrationAsync(user);
        }
        
        public string AddUserRecord(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.AddUserRecord(user);
        }
        
        public System.Threading.Tasks.Task<string> AddUserRecordAsync(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.AddUserRecordAsync(user);
        }
        
        public System.Data.DataSet GetUserRecords() {
            return base.Channel.GetUserRecords();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetUserRecordsAsync() {
            return base.Channel.GetUserRecordsAsync();
        }
        
        public string DeleteRecords(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.DeleteRecords(user);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRecordsAsync(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.DeleteRecordsAsync(user);
        }
        
        public System.Data.DataSet SearchUserRecord(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.SearchUserRecord(user);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchUserRecordAsync(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.SearchUserRecordAsync(user);
        }
        
        public string UpdateUserContact(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.UpdateUserContact(user);
        }
        
        public System.Threading.Tasks.Task<string> UpdateUserContactAsync(GrowTogetherClient.profileref.UserProfile user) {
            return base.Channel.UpdateUserContactAsync(user);
        }
        
        public string SendRequest(GrowTogetherClient.profileref.UserProfile user, GrowTogetherClient.profileref.Message message) {
            return base.Channel.SendRequest(user, message);
        }
        
        public System.Threading.Tasks.Task<string> SendRequestAsync(GrowTogetherClient.profileref.UserProfile user, GrowTogetherClient.profileref.Message message) {
            return base.Channel.SendRequestAsync(user, message);
        }
        
        public System.Data.DataSet GetMessages() {
            return base.Channel.GetMessages();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetMessagesAsync() {
            return base.Channel.GetMessagesAsync();
        }
    }
}
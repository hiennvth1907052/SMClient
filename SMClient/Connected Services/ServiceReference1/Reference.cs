﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SMClient.ServiceReference1.Student.StudentGender GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IntroductionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.DateTime Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
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
        public SMClient.ServiceReference1.Student.StudentGender Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Introduction {
            get {
                return this.IntroductionField;
            }
            set {
                if ((object.ReferenceEquals(this.IntroductionField, value) != true)) {
                    this.IntroductionField = value;
                    this.RaisePropertyChanged("Introduction");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
        [System.Runtime.Serialization.DataContractAttribute(Name="Student.StudentGender", Namespace="http://schemas.datacontract.org/2004/07/")]
        public enum StudentGender : int {
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Male = 0,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Female = 1,
            
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Other = 2,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudents", ReplyAction="http://tempuri.org/IService/GetStudentsResponse")]
        SMClient.ServiceReference1.Student[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStudents", ReplyAction="http://tempuri.org/IService/GetStudentsResponse")]
        System.Threading.Tasks.Task<SMClient.ServiceReference1.Student[]> GetStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddStudent", ReplyAction="http://tempuri.org/IService/AddStudentResponse")]
        SMClient.ServiceReference1.Student AddStudent(SMClient.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddStudent", ReplyAction="http://tempuri.org/IService/AddStudentResponse")]
        System.Threading.Tasks.Task<SMClient.ServiceReference1.Student> AddStudentAsync(SMClient.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Edit", ReplyAction="http://tempuri.org/IService/EditResponse")]
        SMClient.ServiceReference1.Student Edit(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Edit", ReplyAction="http://tempuri.org/IService/EditResponse")]
        System.Threading.Tasks.Task<SMClient.ServiceReference1.Student> EditAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudent", ReplyAction="http://tempuri.org/IService/UpdateStudentResponse")]
        SMClient.ServiceReference1.Student UpdateStudent(SMClient.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateStudent", ReplyAction="http://tempuri.org/IService/UpdateStudentResponse")]
        System.Threading.Tasks.Task<SMClient.ServiceReference1.Student> UpdateStudentAsync(SMClient.ServiceReference1.Student student);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : SMClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<SMClient.ServiceReference1.IService>, SMClient.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SMClient.ServiceReference1.Student[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<SMClient.ServiceReference1.Student[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
        
        public SMClient.ServiceReference1.Student AddStudent(SMClient.ServiceReference1.Student student) {
            return base.Channel.AddStudent(student);
        }
        
        public System.Threading.Tasks.Task<SMClient.ServiceReference1.Student> AddStudentAsync(SMClient.ServiceReference1.Student student) {
            return base.Channel.AddStudentAsync(student);
        }
        
        public SMClient.ServiceReference1.Student Edit(System.Nullable<int> id) {
            return base.Channel.Edit(id);
        }
        
        public System.Threading.Tasks.Task<SMClient.ServiceReference1.Student> EditAsync(System.Nullable<int> id) {
            return base.Channel.EditAsync(id);
        }
        
        public SMClient.ServiceReference1.Student UpdateStudent(SMClient.ServiceReference1.Student student) {
            return base.Channel.UpdateStudent(student);
        }
        
        public System.Threading.Tasks.Task<SMClient.ServiceReference1.Student> UpdateStudentAsync(SMClient.ServiceReference1.Student student) {
            return base.Channel.UpdateStudentAsync(student);
        }
    }
}

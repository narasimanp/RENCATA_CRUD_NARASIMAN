﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeMVCApplication.EmployeeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblEmployee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    [System.SerializableAttribute()]
    public partial class tblEmployee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmpIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public int EmpId {
            get {
                return this.EmpIdField;
            }
            set {
                if ((this.EmpIdField.Equals(value) != true)) {
                    this.EmpIdField = value;
                    this.RaisePropertyChanged("EmpId");
                }
            }
        }

        internal int SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal object Entry(tblEmployee empdtl)
        {
            throw new NotImplementedException();
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployees", ReplyAction="http://tempuri.org/IService1/GetEmployeesResponse")]
        EmployeeMVCApplication.EmployeeServiceReference.tblEmployee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployees", ReplyAction="http://tempuri.org/IService1/GetEmployeesResponse")]
        System.Threading.Tasks.Task<EmployeeMVCApplication.EmployeeServiceReference.tblEmployee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployeeById", ReplyAction="http://tempuri.org/IService1/GetAllEmployeeByIdResponse")]
        EmployeeMVCApplication.EmployeeServiceReference.tblEmployee GetAllEmployeeById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEmployeeById", ReplyAction="http://tempuri.org/IService1/GetAllEmployeeByIdResponse")]
        System.Threading.Tasks.Task<EmployeeMVCApplication.EmployeeServiceReference.tblEmployee> GetAllEmployeeByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployee", ReplyAction="http://tempuri.org/IService1/AddEmployeeResponse")]
        int AddEmployee(int Id, string Name, string Email, string Phone, string Gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployee", ReplyAction="http://tempuri.org/IService1/AddEmployeeResponse")]
        System.Threading.Tasks.Task<int> AddEmployeeAsync(int Id, string Name, string Email, string Phone, string Gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEmployee", ReplyAction="http://tempuri.org/IService1/UpdateEmployeeResponse")]
        int UpdateEmployee(int Id, string Name, string Email, string Phone, string Gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEmployee", ReplyAction="http://tempuri.org/IService1/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<int> UpdateEmployeeAsync(int Id, string Name, string Email, string Phone, string Gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEmployeeById", ReplyAction="http://tempuri.org/IService1/DeleteEmployeeByIdResponse")]
        int DeleteEmployeeById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEmployeeById", ReplyAction="http://tempuri.org/IService1/DeleteEmployeeByIdResponse")]
        System.Threading.Tasks.Task<int> DeleteEmployeeByIdAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : EmployeeMVCApplication.EmployeeServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EmployeeMVCApplication.EmployeeServiceReference.IService1>, EmployeeMVCApplication.EmployeeServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EmployeeMVCApplication.EmployeeServiceReference.tblEmployee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<EmployeeMVCApplication.EmployeeServiceReference.tblEmployee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public EmployeeMVCApplication.EmployeeServiceReference.tblEmployee GetAllEmployeeById(int id) {
            return base.Channel.GetAllEmployeeById(id);
        }
        
        public System.Threading.Tasks.Task<EmployeeMVCApplication.EmployeeServiceReference.tblEmployee> GetAllEmployeeByIdAsync(int id) {
            return base.Channel.GetAllEmployeeByIdAsync(id);
        }
        
        public int AddEmployee(int Id, string Name, string Email, string Phone, string Gender) {
            return base.Channel.AddEmployee(Id, Name, Email, Phone, Gender);
        }
        
        public System.Threading.Tasks.Task<int> AddEmployeeAsync(int Id, string Name, string Email, string Phone, string Gender) {
            return base.Channel.AddEmployeeAsync(Id, Name, Email, Phone, Gender);
        }
        
        public int UpdateEmployee(int Id, string Name, string Email, string Phone, string Gender) {
            return base.Channel.UpdateEmployee(Id, Name, Email, Phone, Gender);
        }
        
        public System.Threading.Tasks.Task<int> UpdateEmployeeAsync(int Id, string Name, string Email, string Phone, string Gender) {
            return base.Channel.UpdateEmployeeAsync(Id, Name, Email, Phone, Gender);
        }
        
        public int DeleteEmployeeById(int Id) {
            return base.Channel.DeleteEmployeeById(Id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteEmployeeByIdAsync(int Id) {
            return base.Channel.DeleteEmployeeByIdAsync(Id);
        }
    }
}

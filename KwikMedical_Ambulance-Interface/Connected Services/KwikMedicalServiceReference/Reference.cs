﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KwikMedical_Ambulance_Interface.KwikMedicalServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/KwikMedical_SA_Coursework2018")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Patient", Namespace="http://schemas.datacontract.org/2004/07/KwikMedical_SA_Coursework2018")]
    [System.SerializableAttribute()]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string detailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hospitalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string houseNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int patientNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string postcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string streetNameField;
        
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
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                if ((this.dateOfBirthField.Equals(value) != true)) {
                    this.dateOfBirthField = value;
                    this.RaisePropertyChanged("dateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string details {
            get {
                return this.detailsField;
            }
            set {
                if ((object.ReferenceEquals(this.detailsField, value) != true)) {
                    this.detailsField = value;
                    this.RaisePropertyChanged("details");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gender {
            get {
                return this.genderField;
            }
            set {
                if ((object.ReferenceEquals(this.genderField, value) != true)) {
                    this.genderField = value;
                    this.RaisePropertyChanged("gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string hospital {
            get {
                return this.hospitalField;
            }
            set {
                if ((object.ReferenceEquals(this.hospitalField, value) != true)) {
                    this.hospitalField = value;
                    this.RaisePropertyChanged("hospital");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string houseNo {
            get {
                return this.houseNoField;
            }
            set {
                if ((object.ReferenceEquals(this.houseNoField, value) != true)) {
                    this.houseNoField = value;
                    this.RaisePropertyChanged("houseNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int patientNo {
            get {
                return this.patientNoField;
            }
            set {
                if ((this.patientNoField.Equals(value) != true)) {
                    this.patientNoField = value;
                    this.RaisePropertyChanged("patientNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string postcode {
            get {
                return this.postcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.postcodeField, value) != true)) {
                    this.postcodeField = value;
                    this.RaisePropertyChanged("postcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string streetName {
            get {
                return this.streetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.streetNameField, value) != true)) {
                    this.streetNameField = value;
                    this.RaisePropertyChanged("streetName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Call", Namespace="http://schemas.datacontract.org/2004/07/KwikMedical_SA_Coursework2018")]
    [System.SerializableAttribute()]
    public partial class Call : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string callDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int callLengthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int patientNoField;
        
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
        public string callDetails {
            get {
                return this.callDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.callDetailsField, value) != true)) {
                    this.callDetailsField = value;
                    this.RaisePropertyChanged("callDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int callLength {
            get {
                return this.callLengthField;
            }
            set {
                if ((this.callLengthField.Equals(value) != true)) {
                    this.callLengthField = value;
                    this.RaisePropertyChanged("callLength");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int patientNo {
            get {
                return this.patientNoField;
            }
            set {
                if ((this.patientNoField.Equals(value) != true)) {
                    this.patientNoField = value;
                    this.RaisePropertyChanged("patientNo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KwikMedicalServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.CompositeType GetDataUsingDataContract(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.CompositeType> GetDataUsingDataContractAsync(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPatient", ReplyAction="http://tempuri.org/IService1/InsertPatientResponse")]
        int InsertPatient(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertPatient", ReplyAction="http://tempuri.org/IService1/InsertPatientResponse")]
        System.Threading.Tasks.Task<int> InsertPatientAsync(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.Patient patient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCall", ReplyAction="http://tempuri.org/IService1/AddCallResponse")]
        int AddCall(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.Call call);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCall", ReplyAction="http://tempuri.org/IService1/AddCallResponse")]
        System.Threading.Tasks.Task<int> AddCallAsync(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.Call call);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.IService1>, KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.CompositeType GetDataUsingDataContract(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.CompositeType> GetDataUsingDataContractAsync(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int InsertPatient(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.Patient patient) {
            return base.Channel.InsertPatient(patient);
        }
        
        public System.Threading.Tasks.Task<int> InsertPatientAsync(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.Patient patient) {
            return base.Channel.InsertPatientAsync(patient);
        }
        
        public int AddCall(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.Call call) {
            return base.Channel.AddCall(call);
        }
        
        public System.Threading.Tasks.Task<int> AddCallAsync(KwikMedical_Ambulance_Interface.KwikMedicalServiceReference.Call call) {
            return base.Channel.AddCallAsync(call);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DT.CodeExam.Web.NumberServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Request", Namespace="http://schemas.datacontract.org/2004/07/DT.CodeExam.Services")]
    [System.SerializableAttribute()]
    public partial class Request : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal NumberField;
        
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
        public decimal Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/DT.CodeExam.Services")]
    [System.SerializableAttribute()]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
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
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NumberServices.INumberServices")]
    public interface INumberServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberServices/Ping", ReplyAction="http://tempuri.org/INumberServices/PingResponse")]
        bool Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberServices/Ping", ReplyAction="http://tempuri.org/INumberServices/PingResponse")]
        System.Threading.Tasks.Task<bool> PingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberServices/Spell", ReplyAction="http://tempuri.org/INumberServices/SpellResponse")]
        DT.CodeExam.Web.NumberServices.Response Spell(DT.CodeExam.Web.NumberServices.Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberServices/Spell", ReplyAction="http://tempuri.org/INumberServices/SpellResponse")]
        System.Threading.Tasks.Task<DT.CodeExam.Web.NumberServices.Response> SpellAsync(DT.CodeExam.Web.NumberServices.Request request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INumberServicesChannel : DT.CodeExam.Web.NumberServices.INumberServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NumberServicesClient : System.ServiceModel.ClientBase<DT.CodeExam.Web.NumberServices.INumberServices>, DT.CodeExam.Web.NumberServices.INumberServices {
        
        public NumberServicesClient() {
        }
        
        public NumberServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NumberServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Ping() {
            return base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task<bool> PingAsync() {
            return base.Channel.PingAsync();
        }
        
        public DT.CodeExam.Web.NumberServices.Response Spell(DT.CodeExam.Web.NumberServices.Request request) {
            return base.Channel.Spell(request);
        }
        
        public System.Threading.Tasks.Task<DT.CodeExam.Web.NumberServices.Response> SpellAsync(DT.CodeExam.Web.NumberServices.Request request) {
            return base.Channel.SpellAsync(request);
        }
    }
}

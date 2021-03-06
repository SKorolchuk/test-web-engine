﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebEngine.Web.Extentions.StatisticsServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatisticsType", Namespace="http://schemas.datacontract.org/2004/07/TestWebEngine.Service.Statistics")]
    [System.SerializableAttribute()]
    public partial class StatisticsType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AverageTestScoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> CompletedTestsCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> LastTestCompletedField;
        
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
        public double AverageTestScore {
            get {
                return this.AverageTestScoreField;
            }
            set {
                if ((this.AverageTestScoreField.Equals(value) != true)) {
                    this.AverageTestScoreField = value;
                    this.RaisePropertyChanged("AverageTestScore");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> CompletedTestsCount {
            get {
                return this.CompletedTestsCountField;
            }
            set {
                if ((this.CompletedTestsCountField.Equals(value) != true)) {
                    this.CompletedTestsCountField = value;
                    this.RaisePropertyChanged("CompletedTestsCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastTestCompleted {
            get {
                return this.LastTestCompletedField;
            }
            set {
                if ((this.LastTestCompletedField.Equals(value) != true)) {
                    this.LastTestCompletedField = value;
                    this.RaisePropertyChanged("LastTestCompleted");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StatisticsServices.IStatisticsService")]
    public interface IStatisticsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/UpdateStatistics", ReplyAction="http://tempuri.org/IStatisticsService/UpdateStatisticsResponse")]
        bool UpdateStatistics(System.Nullable<System.DateTime> date, System.Nullable<double> score);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/UpdateStatistics", ReplyAction="http://tempuri.org/IStatisticsService/UpdateStatisticsResponse")]
        System.Threading.Tasks.Task<bool> UpdateStatisticsAsync(System.Nullable<System.DateTime> date, System.Nullable<double> score);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetStatistics", ReplyAction="http://tempuri.org/IStatisticsService/GetStatisticsResponse")]
        TestWebEngine.Web.Extentions.StatisticsServices.StatisticsType GetStatistics();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetStatistics", ReplyAction="http://tempuri.org/IStatisticsService/GetStatisticsResponse")]
        System.Threading.Tasks.Task<TestWebEngine.Web.Extentions.StatisticsServices.StatisticsType> GetStatisticsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStatisticsServiceChannel : TestWebEngine.Web.Extentions.StatisticsServices.IStatisticsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StatisticsServiceClient : System.ServiceModel.ClientBase<TestWebEngine.Web.Extentions.StatisticsServices.IStatisticsService>, TestWebEngine.Web.Extentions.StatisticsServices.IStatisticsService {
        
        public StatisticsServiceClient() {
        }
        
        public StatisticsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StatisticsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatisticsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatisticsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool UpdateStatistics(System.Nullable<System.DateTime> date, System.Nullable<double> score) {
            return base.Channel.UpdateStatistics(date, score);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateStatisticsAsync(System.Nullable<System.DateTime> date, System.Nullable<double> score) {
            return base.Channel.UpdateStatisticsAsync(date, score);
        }
        
        public TestWebEngine.Web.Extentions.StatisticsServices.StatisticsType GetStatistics() {
            return base.Channel.GetStatistics();
        }
        
        public System.Threading.Tasks.Task<TestWebEngine.Web.Extentions.StatisticsServices.StatisticsType> GetStatisticsAsync() {
            return base.Channel.GetStatisticsAsync();
        }
    }
}

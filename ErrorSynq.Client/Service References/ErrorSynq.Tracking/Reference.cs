﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErrorSynq {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TrackingInfo", Namespace="http://schemas.datacontract.org/2004/07/Terrasynq.Tracking")]
    [System.SerializableAttribute()]
    internal partial class TrackingInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateLoggedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<ErrorSynq.ErrorCauses> ErrorCauseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorSourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HtmlErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsReadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsResolvedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ErrorSynq.KeyValueModel> PostDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ErrorSynq.KeyValueModel> QueryStringDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RawUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ErrorSynq.KeyValueModel> ServerVariablesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ErrorSynq.KeyValueModel> SessionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid SiteKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TargetSiteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserAccountNameField;
        
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
        internal System.Nullable<System.DateTime> DateLogged {
            get {
                return this.DateLoggedField;
            }
            set {
                if ((this.DateLoggedField.Equals(value) != true)) {
                    this.DateLoggedField = value;
                    this.RaisePropertyChanged("DateLogged");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<ErrorSynq.ErrorCauses> ErrorCause {
            get {
                return this.ErrorCauseField;
            }
            set {
                if ((this.ErrorCauseField.Equals(value) != true)) {
                    this.ErrorCauseField = value;
                    this.RaisePropertyChanged("ErrorCause");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ErrorPath {
            get {
                return this.ErrorPathField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorPathField, value) != true)) {
                    this.ErrorPathField = value;
                    this.RaisePropertyChanged("ErrorPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ErrorSource {
            get {
                return this.ErrorSourceField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorSourceField, value) != true)) {
                    this.ErrorSourceField = value;
                    this.RaisePropertyChanged("ErrorSource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ErrorType {
            get {
                return this.ErrorTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorTypeField, value) != true)) {
                    this.ErrorTypeField = value;
                    this.RaisePropertyChanged("ErrorType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string HtmlErrorMessage {
            get {
                return this.HtmlErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.HtmlErrorMessageField, value) != true)) {
                    this.HtmlErrorMessageField = value;
                    this.RaisePropertyChanged("HtmlErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<bool> IsRead {
            get {
                return this.IsReadField;
            }
            set {
                if ((this.IsReadField.Equals(value) != true)) {
                    this.IsReadField = value;
                    this.RaisePropertyChanged("IsRead");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<bool> IsResolved {
            get {
                return this.IsResolvedField;
            }
            set {
                if ((this.IsResolvedField.Equals(value) != true)) {
                    this.IsResolvedField = value;
                    this.RaisePropertyChanged("IsResolved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Collections.Generic.List<ErrorSynq.KeyValueModel> PostData {
            get {
                return this.PostDataField;
            }
            set {
                if ((object.ReferenceEquals(this.PostDataField, value) != true)) {
                    this.PostDataField = value;
                    this.RaisePropertyChanged("PostData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Collections.Generic.List<ErrorSynq.KeyValueModel> QueryStringData {
            get {
                return this.QueryStringDataField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryStringDataField, value) != true)) {
                    this.QueryStringDataField = value;
                    this.RaisePropertyChanged("QueryStringData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string RawUrl {
            get {
                return this.RawUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.RawUrlField, value) != true)) {
                    this.RawUrlField = value;
                    this.RaisePropertyChanged("RawUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Collections.Generic.List<ErrorSynq.KeyValueModel> ServerVariables {
            get {
                return this.ServerVariablesField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerVariablesField, value) != true)) {
                    this.ServerVariablesField = value;
                    this.RaisePropertyChanged("ServerVariables");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Collections.Generic.List<ErrorSynq.KeyValueModel> SessionData {
            get {
                return this.SessionDataField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionDataField, value) != true)) {
                    this.SessionDataField = value;
                    this.RaisePropertyChanged("SessionData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Guid SiteKey {
            get {
                return this.SiteKeyField;
            }
            set {
                if ((this.SiteKeyField.Equals(value) != true)) {
                    this.SiteKeyField = value;
                    this.RaisePropertyChanged("SiteKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string TargetSite {
            get {
                return this.TargetSiteField;
            }
            set {
                if ((object.ReferenceEquals(this.TargetSiteField, value) != true)) {
                    this.TargetSiteField = value;
                    this.RaisePropertyChanged("TargetSite");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string UserAccountName {
            get {
                return this.UserAccountNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserAccountNameField, value) != true)) {
                    this.UserAccountNameField = value;
                    this.RaisePropertyChanged("UserAccountName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorCauses", Namespace="http://schemas.datacontract.org/2004/07/Terrasynq.Tracking")]
    internal enum ErrorCauses : byte {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Bug = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MissingFile = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IncorrectPath = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ObsoleteLink = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Attack = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="KeyValueModel", Namespace="http://schemas.datacontract.org/2004/07/Terrasynq.Tracking")]
    [System.SerializableAttribute()]
    internal partial class KeyValueModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        internal string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorTrackingSummaryModel", Namespace="http://schemas.datacontract.org/2004/07/Terrasynq.Tracking")]
    [System.SerializableAttribute()]
    internal partial class ErrorTrackingSummaryModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ErrorMessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LastIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> LastOccurenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OccurencesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RawUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long RawUrlIDField;
        
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
        internal string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal long ErrorMessageID {
            get {
                return this.ErrorMessageIDField;
            }
            set {
                if ((this.ErrorMessageIDField.Equals(value) != true)) {
                    this.ErrorMessageIDField = value;
                    this.RaisePropertyChanged("ErrorMessageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal long LastID {
            get {
                return this.LastIDField;
            }
            set {
                if ((this.LastIDField.Equals(value) != true)) {
                    this.LastIDField = value;
                    this.RaisePropertyChanged("LastID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<System.DateTime> LastOccurence {
            get {
                return this.LastOccurenceField;
            }
            set {
                if ((this.LastOccurenceField.Equals(value) != true)) {
                    this.LastOccurenceField = value;
                    this.RaisePropertyChanged("LastOccurence");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal int Occurences {
            get {
                return this.OccurencesField;
            }
            set {
                if ((this.OccurencesField.Equals(value) != true)) {
                    this.OccurencesField = value;
                    this.RaisePropertyChanged("Occurences");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string RawUrl {
            get {
                return this.RawUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.RawUrlField, value) != true)) {
                    this.RawUrlField = value;
                    this.RaisePropertyChanged("RawUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal long RawUrlID {
            get {
                return this.RawUrlIDField;
            }
            set {
                if ((this.RawUrlIDField.Equals(value) != true)) {
                    this.RawUrlIDField = value;
                    this.RaisePropertyChanged("RawUrlID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorTrackingModel", Namespace="http://schemas.datacontract.org/2004/07/Terrasynq.Tracking")]
    [System.SerializableAttribute()]
    internal partial class ErrorTrackingModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateLoggedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<ErrorSynq.ErrorCauses> ErrorCauseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ErrorMessageIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorSourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HtmlErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsReadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsResolvedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LogIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ErrorSynq.KeyValueModel> PostDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ErrorSynq.KeyValueModel> QueryStringDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RawURLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long RawURLIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ErrorSynq.KeyValueModel> ServerVariablesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ErrorSynq.KeyValueModel> SessionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TargetSiteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserAccountNameField;
        
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
        internal System.DateTime DateLogged {
            get {
                return this.DateLoggedField;
            }
            set {
                if ((this.DateLoggedField.Equals(value) != true)) {
                    this.DateLoggedField = value;
                    this.RaisePropertyChanged("DateLogged");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Nullable<ErrorSynq.ErrorCauses> ErrorCause {
            get {
                return this.ErrorCauseField;
            }
            set {
                if ((this.ErrorCauseField.Equals(value) != true)) {
                    this.ErrorCauseField = value;
                    this.RaisePropertyChanged("ErrorCause");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal long ErrorMessageID {
            get {
                return this.ErrorMessageIDField;
            }
            set {
                if ((this.ErrorMessageIDField.Equals(value) != true)) {
                    this.ErrorMessageIDField = value;
                    this.RaisePropertyChanged("ErrorMessageID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ErrorPath {
            get {
                return this.ErrorPathField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorPathField, value) != true)) {
                    this.ErrorPathField = value;
                    this.RaisePropertyChanged("ErrorPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ErrorSource {
            get {
                return this.ErrorSourceField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorSourceField, value) != true)) {
                    this.ErrorSourceField = value;
                    this.RaisePropertyChanged("ErrorSource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string ErrorType {
            get {
                return this.ErrorTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorTypeField, value) != true)) {
                    this.ErrorTypeField = value;
                    this.RaisePropertyChanged("ErrorType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string HtmlErrorMessage {
            get {
                return this.HtmlErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.HtmlErrorMessageField, value) != true)) {
                    this.HtmlErrorMessageField = value;
                    this.RaisePropertyChanged("HtmlErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal bool IsRead {
            get {
                return this.IsReadField;
            }
            set {
                if ((this.IsReadField.Equals(value) != true)) {
                    this.IsReadField = value;
                    this.RaisePropertyChanged("IsRead");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal bool IsResolved {
            get {
                return this.IsResolvedField;
            }
            set {
                if ((this.IsResolvedField.Equals(value) != true)) {
                    this.IsResolvedField = value;
                    this.RaisePropertyChanged("IsResolved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal long LogID {
            get {
                return this.LogIDField;
            }
            set {
                if ((this.LogIDField.Equals(value) != true)) {
                    this.LogIDField = value;
                    this.RaisePropertyChanged("LogID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Collections.Generic.List<ErrorSynq.KeyValueModel> PostData {
            get {
                return this.PostDataField;
            }
            set {
                if ((object.ReferenceEquals(this.PostDataField, value) != true)) {
                    this.PostDataField = value;
                    this.RaisePropertyChanged("PostData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Collections.Generic.List<ErrorSynq.KeyValueModel> QueryStringData {
            get {
                return this.QueryStringDataField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryStringDataField, value) != true)) {
                    this.QueryStringDataField = value;
                    this.RaisePropertyChanged("QueryStringData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string RawURL {
            get {
                return this.RawURLField;
            }
            set {
                if ((object.ReferenceEquals(this.RawURLField, value) != true)) {
                    this.RawURLField = value;
                    this.RaisePropertyChanged("RawURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal long RawURLID {
            get {
                return this.RawURLIDField;
            }
            set {
                if ((this.RawURLIDField.Equals(value) != true)) {
                    this.RawURLIDField = value;
                    this.RaisePropertyChanged("RawURLID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Collections.Generic.List<ErrorSynq.KeyValueModel> ServerVariables {
            get {
                return this.ServerVariablesField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerVariablesField, value) != true)) {
                    this.ServerVariablesField = value;
                    this.RaisePropertyChanged("ServerVariables");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal System.Collections.Generic.List<ErrorSynq.KeyValueModel> SessionData {
            get {
                return this.SessionDataField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionDataField, value) != true)) {
                    this.SessionDataField = value;
                    this.RaisePropertyChanged("SessionData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string TargetSite {
            get {
                return this.TargetSiteField;
            }
            set {
                if ((object.ReferenceEquals(this.TargetSiteField, value) != true)) {
                    this.TargetSiteField = value;
                    this.RaisePropertyChanged("TargetSite");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        internal string UserAccountName {
            get {
                return this.UserAccountNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserAccountNameField, value) != true)) {
                    this.UserAccountNameField = value;
                    this.RaisePropertyChanged("UserAccountName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ErrorSynq.IErrorTrackingService")]
    internal interface IErrorTrackingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IErrorTrackingService/SubmitError", ReplyAction="http://tempuri.org/IErrorTrackingService/SubmitErrorResponse")]
        bool SubmitError(ErrorSynq.TrackingInfo error);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IErrorTrackingService/GetUnresolvedErrors", ReplyAction="http://tempuri.org/IErrorTrackingService/GetUnresolvedErrorsResponse")]
        System.Collections.Generic.List<ErrorSynq.ErrorTrackingSummaryModel> GetUnresolvedErrors(System.Guid siteKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IErrorTrackingService/GetResolvedErrors", ReplyAction="http://tempuri.org/IErrorTrackingService/GetResolvedErrorsResponse")]
        System.Collections.Generic.List<ErrorSynq.ErrorTrackingSummaryModel> GetResolvedErrors(System.Guid siteKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IErrorTrackingService/MarkResolved", ReplyAction="http://tempuri.org/IErrorTrackingService/MarkResolvedResponse")]
        bool MarkResolved(System.Guid siteKey, long RawUrlID, long ErrorMessageID, string Reason, string Solution, byte ErrorCause);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IErrorTrackingService/GetAllErrors", ReplyAction="http://tempuri.org/IErrorTrackingService/GetAllErrorsResponse")]
        System.Collections.Generic.List<ErrorSynq.TrackingInfo> GetAllErrors(string siteKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IErrorTrackingService/GetErrorsByCause", ReplyAction="http://tempuri.org/IErrorTrackingService/GetErrorsByCauseResponse")]
        System.Collections.Generic.List<ErrorSynq.TrackingInfo> GetErrorsByCause(string siteKey, ErrorSynq.ErrorCauses cause);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IErrorTrackingService/GetErrorByID", ReplyAction="http://tempuri.org/IErrorTrackingService/GetErrorByIDResponse")]
        ErrorSynq.ErrorTrackingModel GetErrorByID(System.Guid siteKey, int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface IErrorTrackingServiceChannel : ErrorSynq.IErrorTrackingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class ErrorTrackingServiceClient : System.ServiceModel.ClientBase<ErrorSynq.IErrorTrackingService>, ErrorSynq.IErrorTrackingService {
        
        public ErrorTrackingServiceClient() {
        }
        
        public ErrorTrackingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ErrorTrackingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ErrorTrackingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ErrorTrackingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SubmitError(ErrorSynq.TrackingInfo error) {
            return base.Channel.SubmitError(error);
        }
        
        public System.Collections.Generic.List<ErrorSynq.ErrorTrackingSummaryModel> GetUnresolvedErrors(System.Guid siteKey) {
            return base.Channel.GetUnresolvedErrors(siteKey);
        }
        
        public System.Collections.Generic.List<ErrorSynq.ErrorTrackingSummaryModel> GetResolvedErrors(System.Guid siteKey) {
            return base.Channel.GetResolvedErrors(siteKey);
        }
        
        public bool MarkResolved(System.Guid siteKey, long RawUrlID, long ErrorMessageID, string Reason, string Solution, byte ErrorCause) {
            return base.Channel.MarkResolved(siteKey, RawUrlID, ErrorMessageID, Reason, Solution, ErrorCause);
        }
        
        public System.Collections.Generic.List<ErrorSynq.TrackingInfo> GetAllErrors(string siteKey) {
            return base.Channel.GetAllErrors(siteKey);
        }
        
        public System.Collections.Generic.List<ErrorSynq.TrackingInfo> GetErrorsByCause(string siteKey, ErrorSynq.ErrorCauses cause) {
            return base.Channel.GetErrorsByCause(siteKey, cause);
        }
        
        public ErrorSynq.ErrorTrackingModel GetErrorByID(System.Guid siteKey, int id) {
            return base.Channel.GetErrorByID(siteKey, id);
        }
    }
}

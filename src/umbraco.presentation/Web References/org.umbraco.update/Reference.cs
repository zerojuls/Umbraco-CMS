﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17626.
// 
#pragma warning disable 1591

namespace umbraco.presentation.org.umbraco.update {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CheckForUpgradeSoap", Namespace="http://update.umbraco.org/")]
    public partial class CheckForUpgrade : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CheckUpgradeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CheckForUpgrade() {
            this.Url = global::umbraco.presentation.Properties.Settings.Default.umbraco_org_umbraco_update_CheckForUpgrade;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CheckUpgradeCompletedEventHandler CheckUpgradeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://update.umbraco.org/CheckUpgrade", RequestNamespace="http://update.umbraco.org/", ResponseNamespace="http://update.umbraco.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UpgradeResult CheckUpgrade(int VersionMajor, int VersionMinor, int VersionPatch, string versionComment) {
            object[] results = this.Invoke("CheckUpgrade", new object[] {
                        VersionMajor,
                        VersionMinor,
                        VersionPatch,
                        versionComment});
            return ((UpgradeResult)(results[0]));
        }
        
        /// <remarks/>
        public void CheckUpgradeAsync(int VersionMajor, int VersionMinor, int VersionPatch, string versionComment) {
            this.CheckUpgradeAsync(VersionMajor, VersionMinor, VersionPatch, versionComment, null);
        }
        
        /// <remarks/>
        public void CheckUpgradeAsync(int VersionMajor, int VersionMinor, int VersionPatch, string versionComment, object userState) {
            if ((this.CheckUpgradeOperationCompleted == null)) {
                this.CheckUpgradeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUpgradeOperationCompleted);
            }
            this.InvokeAsync("CheckUpgrade", new object[] {
                        VersionMajor,
                        VersionMinor,
                        VersionPatch,
                        versionComment}, this.CheckUpgradeOperationCompleted, userState);
        }
        
        private void OnCheckUpgradeOperationCompleted(object arg) {
            if ((this.CheckUpgradeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUpgradeCompleted(this, new CheckUpgradeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17626")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://update.umbraco.org/")]
    public partial class UpgradeResult {
        
        private UpgradeType upgradeTypeField;
        
        private string commentField;
        
        private string upgradeUrlField;
        
        /// <remarks/>
        public UpgradeType UpgradeType {
            get {
                return this.upgradeTypeField;
            }
            set {
                this.upgradeTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public string UpgradeUrl {
            get {
                return this.upgradeUrlField;
            }
            set {
                this.upgradeUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17626")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://update.umbraco.org/")]
    public enum UpgradeType {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Patch,
        
        /// <remarks/>
        Minor,
        
        /// <remarks/>
        Major,
        
        /// <remarks/>
        Critical,
        
        /// <remarks/>
        Error,
        
        /// <remarks/>
        OutOfSync,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    public delegate void CheckUpgradeCompletedEventHandler(object sender, CheckUpgradeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUpgradeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckUpgradeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UpgradeResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UpgradeResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
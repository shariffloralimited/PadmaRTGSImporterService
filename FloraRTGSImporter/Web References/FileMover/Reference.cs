﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace RTGSImporter.FileMover {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AreYouUpOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFileListOperationCompleted;
        
        private System.Threading.SendOrPostCallback SaveDocumentOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDocumentOperationCompleted;
        
        private System.Threading.SendOrPostCallback BackupFileOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::RTGSImporter.Properties.Settings.Default.RTGSImporter_FileMover_Service1;
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
        public event AreYouUpCompletedEventHandler AreYouUpCompleted;
        
        /// <remarks/>
        public event GetFileListCompletedEventHandler GetFileListCompleted;
        
        /// <remarks/>
        public event SaveDocumentCompletedEventHandler SaveDocumentCompleted;
        
        /// <remarks/>
        public event GetDocumentCompletedEventHandler GetDocumentCompleted;
        
        /// <remarks/>
        public event BackupFileCompletedEventHandler BackupFileCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AreYouUp", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AreYouUp() {
            object[] results = this.Invoke("AreYouUp", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AreYouUpAsync() {
            this.AreYouUpAsync(null);
        }
        
        /// <remarks/>
        public void AreYouUpAsync(object userState) {
            if ((this.AreYouUpOperationCompleted == null)) {
                this.AreYouUpOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAreYouUpOperationCompleted);
            }
            this.InvokeAsync("AreYouUp", new object[0], this.AreYouUpOperationCompleted, userState);
        }
        
        private void OnAreYouUpOperationCompleted(object arg) {
            if ((this.AreYouUpCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AreYouUpCompleted(this, new AreYouUpCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFileList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetFileList(string Path, string SearchString) {
            object[] results = this.Invoke("GetFileList", new object[] {
                        Path,
                        SearchString});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetFileListAsync(string Path, string SearchString) {
            this.GetFileListAsync(Path, SearchString, null);
        }
        
        /// <remarks/>
        public void GetFileListAsync(string Path, string SearchString, object userState) {
            if ((this.GetFileListOperationCompleted == null)) {
                this.GetFileListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileListOperationCompleted);
            }
            this.InvokeAsync("GetFileList", new object[] {
                        Path,
                        SearchString}, this.GetFileListOperationCompleted, userState);
        }
        
        private void OnGetFileListOperationCompleted(object arg) {
            if ((this.GetFileListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileListCompleted(this, new GetFileListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveDocument", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SaveDocument(string Path, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] docarray, string docname) {
            object[] results = this.Invoke("SaveDocument", new object[] {
                        Path,
                        docarray,
                        docname});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void SaveDocumentAsync(string Path, byte[] docarray, string docname) {
            this.SaveDocumentAsync(Path, docarray, docname, null);
        }
        
        /// <remarks/>
        public void SaveDocumentAsync(string Path, byte[] docarray, string docname, object userState) {
            if ((this.SaveDocumentOperationCompleted == null)) {
                this.SaveDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveDocumentOperationCompleted);
            }
            this.InvokeAsync("SaveDocument", new object[] {
                        Path,
                        docarray,
                        docname}, this.SaveDocumentOperationCompleted, userState);
        }
        
        private void OnSaveDocumentOperationCompleted(object arg) {
            if ((this.SaveDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveDocumentCompleted(this, new SaveDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDocument", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] GetDocument(string Path, string DocumentName) {
            object[] results = this.Invoke("GetDocument", new object[] {
                        Path,
                        DocumentName});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void GetDocumentAsync(string Path, string DocumentName) {
            this.GetDocumentAsync(Path, DocumentName, null);
        }
        
        /// <remarks/>
        public void GetDocumentAsync(string Path, string DocumentName, object userState) {
            if ((this.GetDocumentOperationCompleted == null)) {
                this.GetDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentOperationCompleted);
            }
            this.InvokeAsync("GetDocument", new object[] {
                        Path,
                        DocumentName}, this.GetDocumentOperationCompleted, userState);
        }
        
        private void OnGetDocumentOperationCompleted(object arg) {
            if ((this.GetDocumentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentCompleted(this, new GetDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BackupFile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void BackupFile(string file) {
            this.Invoke("BackupFile", new object[] {
                        file});
        }
        
        /// <remarks/>
        public void BackupFileAsync(string file) {
            this.BackupFileAsync(file, null);
        }
        
        /// <remarks/>
        public void BackupFileAsync(string file, object userState) {
            if ((this.BackupFileOperationCompleted == null)) {
                this.BackupFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBackupFileOperationCompleted);
            }
            this.InvokeAsync("BackupFile", new object[] {
                        file}, this.BackupFileOperationCompleted, userState);
        }
        
        private void OnBackupFileOperationCompleted(object arg) {
            if ((this.BackupFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BackupFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void AreYouUpCompletedEventHandler(object sender, AreYouUpCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AreYouUpCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AreYouUpCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetFileListCompletedEventHandler(object sender, GetFileListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFileListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void SaveDocumentCompletedEventHandler(object sender, SaveDocumentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SaveDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SaveDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetDocumentCompletedEventHandler(object sender, GetDocumentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void BackupFileCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591
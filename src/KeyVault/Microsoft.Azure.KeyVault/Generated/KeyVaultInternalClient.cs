// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure.KeyVault.Internal;

namespace Microsoft.Azure.KeyVault.Internal
{
    internal partial class KeyVaultInternalClient : ServiceClient<KeyVaultInternalClient>, IKeyVaultInternalClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private KeyVaultCredential _credentials;
        
        /// <summary>
        /// Gets or sets the credential
        /// </summary>
        public KeyVaultCredential Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private IKeyOperations _keys;
        
        /// <summary>
        /// Cryptographic and management operations for keys in a vault
        /// </summary>
        public virtual IKeyOperations Keys
        {
            get { return this._keys; }
        }
        
        private ISecretOperations _secrets;
        
        /// <summary>
        /// Operations for secrets in a vault
        /// </summary>
        public virtual ISecretOperations Secrets
        {
            get { return this._secrets; }
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyVaultInternalClient class.
        /// </summary>
        public KeyVaultInternalClient()
            : base()
        {
            this._keys = new KeyOperations(this);
            this._secrets = new SecretOperations(this);
            this._apiVersion = "2015-06-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyVaultInternalClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets or sets the credential
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public KeyVaultInternalClient(KeyVaultCredential credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyVaultInternalClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets or sets the credential
        /// </param>
        public KeyVaultInternalClient(KeyVaultCredential credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = null;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyVaultInternalClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public KeyVaultInternalClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._keys = new KeyOperations(this);
            this._secrets = new SecretOperations(this);
            this._apiVersion = "2015-06-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyVaultInternalClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets or sets the credential
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public KeyVaultInternalClient(KeyVaultCredential credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the KeyVaultInternalClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets or sets the credential
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public KeyVaultInternalClient(KeyVaultCredential credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = null;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// KeyVaultInternalClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of KeyVaultInternalClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<KeyVaultInternalClient> client)
        {
            base.Clone(client);
            
            if (client is KeyVaultInternalClient)
            {
                KeyVaultInternalClient clonedClient = ((KeyVaultInternalClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}

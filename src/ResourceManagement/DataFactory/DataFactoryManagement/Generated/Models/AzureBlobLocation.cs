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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The Azure blob storage.
    /// </summary>
    public partial class AzureBlobLocation : TableLocation
    {
        private Compression _compression;
        
        /// <summary>
        /// Optional. Gets or sets the data compression method used for the
        /// blob storage.
        /// </summary>
        public Compression Compression
        {
            get { return this._compression; }
            set { this._compression = value; }
        }
        
        private string _fileName;
        
        /// <summary>
        /// Optional. The name of the Azure blob.
        /// </summary>
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }
        
        private string _folderPath;
        
        /// <summary>
        /// Optional. The path of the Azure blob storage.
        /// </summary>
        public string FolderPath
        {
            get { return this._folderPath; }
            set { this._folderPath = value; }
        }
        
        private StorageFormat _format;
        
        /// <summary>
        /// Optional. The format of the Azure blob storage.
        /// </summary>
        public StorageFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }
        
        private IList<Partition> _partitionedBy;
        
        /// <summary>
        /// Optional. The partitions to be used by the path.
        /// </summary>
        public IList<Partition> PartitionedBy
        {
            get { return this._partitionedBy; }
            set { this._partitionedBy = value; }
        }
        
        private string _tableRootLocation;
        
        /// <summary>
        /// Optional. The root of blob path.
        /// </summary>
        public string TableRootLocation
        {
            get { return this._tableRootLocation; }
            set { this._tableRootLocation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureBlobLocation class.
        /// </summary>
        public AzureBlobLocation()
        {
            this.PartitionedBy = new LazyList<Partition>();
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureBlobLocation class with
        /// required arguments.
        /// </summary>
        public AzureBlobLocation(string linkedServiceName)
            : this()
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException("linkedServiceName");
            }
            this.LinkedServiceName = linkedServiceName;
        }
    }
}

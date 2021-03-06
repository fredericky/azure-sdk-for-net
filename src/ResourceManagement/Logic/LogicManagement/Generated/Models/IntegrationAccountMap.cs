// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class IntegrationAccountMap : IntegrationAccountResource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountMap class.
        /// </summary>
        public IntegrationAccountMap() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountMap class.
        /// </summary>
        public IntegrationAccountMap(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), MapType? mapType = default(MapType?), DateTime? createdTime = default(DateTime?), DateTime? changedTime = default(DateTime?), object content = default(object), string contentType = default(string), IntegrationAccountContentLink contentLink = default(IntegrationAccountContentLink), object metadata = default(object))
            : base(id, name, type, location, tags)
        {
            MapType = mapType;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            Content = content;
            ContentType = contentType;
            ContentLink = contentLink;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets the map type. Possible values include:
        /// 'NotSpecified', 'Xslt'
        /// </summary>
        [JsonProperty(PropertyName = "properties.mapType")]
        public MapType? MapType { get; set; }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public DateTime? ChangedTime { get; private set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        [JsonProperty(PropertyName = "properties.content")]
        public object Content { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets the content link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentLink")]
        public IntegrationAccountContentLink ContentLink { get; private set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; set; }

    }
}

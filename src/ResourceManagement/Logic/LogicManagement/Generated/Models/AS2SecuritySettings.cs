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
    public partial class AS2SecuritySettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2SecuritySettings class.
        /// </summary>
        public AS2SecuritySettings() { }

        /// <summary>
        /// Initializes a new instance of the AS2SecuritySettings class.
        /// </summary>
        public AS2SecuritySettings(bool? overrideGroupSigningCertificate = default(bool?), string signingCertificateName = default(string), string encryptionCertificateName = default(string), bool? enableNrrForInboundEncodedMessages = default(bool?), bool? enableNrrForInboundDecodedMessages = default(bool?), bool? enableNrrForOutboundMdn = default(bool?), bool? enableNrrForOutboundEncodedMessages = default(bool?), bool? enableNrrForOutboundDecodedMessages = default(bool?), bool? enableNrrForInboundMdn = default(bool?))
        {
            OverrideGroupSigningCertificate = overrideGroupSigningCertificate;
            SigningCertificateName = signingCertificateName;
            EncryptionCertificateName = encryptionCertificateName;
            EnableNrrForInboundEncodedMessages = enableNrrForInboundEncodedMessages;
            EnableNrrForInboundDecodedMessages = enableNrrForInboundDecodedMessages;
            EnableNrrForOutboundMdn = enableNrrForOutboundMdn;
            EnableNrrForOutboundEncodedMessages = enableNrrForOutboundEncodedMessages;
            EnableNrrForOutboundDecodedMessages = enableNrrForOutboundDecodedMessages;
            EnableNrrForInboundMdn = enableNrrForInboundMdn;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to send or request a MDN.
        /// </summary>
        [JsonProperty(PropertyName = "overrideGroupSigningCertificate")]
        public bool? OverrideGroupSigningCertificate { get; set; }

        /// <summary>
        /// Gets or sets the name of the signing certificate.
        /// </summary>
        [JsonProperty(PropertyName = "signingCertificateName")]
        public string SigningCertificateName { get; set; }

        /// <summary>
        /// Gets or sets the name of the encryption certificate.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionCertificateName")]
        public string EncryptionCertificateName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable NRR for inbound
        /// encoded messages.
        /// </summary>
        [JsonProperty(PropertyName = "enableNrrForInboundEncodedMessages")]
        public bool? EnableNrrForInboundEncodedMessages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable NRR for inbound
        /// decoded messages.
        /// </summary>
        [JsonProperty(PropertyName = "enableNrrForInboundDecodedMessages")]
        public bool? EnableNrrForInboundDecodedMessages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable NRR for outbound
        /// MDN.
        /// </summary>
        [JsonProperty(PropertyName = "enableNrrForOutboundMdn")]
        public bool? EnableNrrForOutboundMdn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable NRR for outbound
        /// encoded messages.
        /// </summary>
        [JsonProperty(PropertyName = "enableNrrForOutboundEncodedMessages")]
        public bool? EnableNrrForOutboundEncodedMessages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable NRR for outbound
        /// decoded messages.
        /// </summary>
        [JsonProperty(PropertyName = "enableNrrForOutboundDecodedMessages")]
        public bool? EnableNrrForOutboundDecodedMessages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to enable NRR for inbound
        /// MDN.
        /// </summary>
        [JsonProperty(PropertyName = "enableNrrForInboundMdn")]
        public bool? EnableNrrForInboundMdn { get; set; }

    }
}

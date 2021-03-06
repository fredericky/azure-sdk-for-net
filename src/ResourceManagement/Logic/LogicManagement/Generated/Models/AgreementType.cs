// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AgreementType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgreementType
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "AS2")]
        AS2,
        [EnumMember(Value = "X12")]
        X12,
        [EnumMember(Value = "Edifact")]
        Edifact
    }
}

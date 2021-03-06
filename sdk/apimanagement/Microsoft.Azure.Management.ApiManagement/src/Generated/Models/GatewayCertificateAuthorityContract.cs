// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Gateway certificate authority details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GatewayCertificateAuthorityContract : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GatewayCertificateAuthorityContract class.
        /// </summary>
        public GatewayCertificateAuthorityContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GatewayCertificateAuthorityContract class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type for API Management
        /// resource.</param>
        /// <param name="isTrusted">Determines whether certificate authority is
        /// trusted.</param>
        public GatewayCertificateAuthorityContract(string id = default(string), string name = default(string), string type = default(string), bool? isTrusted = default(bool?))
            : base(id, name, type)
        {
            IsTrusted = isTrusted;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets determines whether certificate authority is trusted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isTrusted")]
        public bool? IsTrusted { get; set; }

    }
}

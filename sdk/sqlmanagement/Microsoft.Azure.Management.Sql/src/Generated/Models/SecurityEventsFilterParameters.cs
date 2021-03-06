// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties that are supported in the $filter operation.
    /// </summary>
    public partial class SecurityEventsFilterParameters
    {
        /// <summary>
        /// Initializes a new instance of the SecurityEventsFilterParameters
        /// class.
        /// </summary>
        public SecurityEventsFilterParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityEventsFilterParameters
        /// class.
        /// </summary>
        /// <param name="eventTime">Filter on the event time.</param>
        /// <param name="showServerRecords">Whether to show server records or
        /// not.</param>
        public SecurityEventsFilterParameters(System.DateTime? eventTime = default(System.DateTime?), bool? showServerRecords = default(bool?))
        {
            EventTime = eventTime;
            ShowServerRecords = showServerRecords;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filter on the event time.
        /// </summary>
        [JsonProperty(PropertyName = "eventTime")]
        public System.DateTime? EventTime { get; set; }

        /// <summary>
        /// Gets or sets whether to show server records or not.
        /// </summary>
        [JsonProperty(PropertyName = "showServerRecords")]
        public bool? ShowServerRecords { get; set; }

    }
}

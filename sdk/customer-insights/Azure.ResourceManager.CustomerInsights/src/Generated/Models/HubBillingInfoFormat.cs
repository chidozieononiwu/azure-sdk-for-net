// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Hub billing info. </summary>
    public partial class HubBillingInfoFormat
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HubBillingInfoFormat"/>. </summary>
        public HubBillingInfoFormat()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HubBillingInfoFormat"/>. </summary>
        /// <param name="skuName"> The sku name. </param>
        /// <param name="minUnits"> The minimum number of units will be billed. One unit is 10,000 Profiles and 100,000 Interactions. </param>
        /// <param name="maxUnits"> The maximum number of units can be used.  One unit is 10,000 Profiles and 100,000 Interactions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HubBillingInfoFormat(string skuName, int? minUnits, int? maxUnits, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SkuName = skuName;
            MinUnits = minUnits;
            MaxUnits = maxUnits;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The sku name. </summary>
        public string SkuName { get; set; }
        /// <summary> The minimum number of units will be billed. One unit is 10,000 Profiles and 100,000 Interactions. </summary>
        public int? MinUnits { get; set; }
        /// <summary> The maximum number of units can be used.  One unit is 10,000 Profiles and 100,000 Interactions. </summary>
        public int? MaxUnits { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerServiceNewKubernetesVersionAvailableEventDataConverter))]
    public partial class ContainerServiceNewKubernetesVersionAvailableEventData
    {
        internal static ContainerServiceNewKubernetesVersionAvailableEventData DeserializeContainerServiceNewKubernetesVersionAvailableEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string latestSupportedKubernetesVersion = default;
            string latestStableKubernetesVersion = default;
            string lowestMinorKubernetesVersion = default;
            string latestPreviewKubernetesVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("latestSupportedKubernetesVersion"u8))
                {
                    latestSupportedKubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestStableKubernetesVersion"u8))
                {
                    latestStableKubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lowestMinorKubernetesVersion"u8))
                {
                    lowestMinorKubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("latestPreviewKubernetesVersion"u8))
                {
                    latestPreviewKubernetesVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceNewKubernetesVersionAvailableEventData(latestSupportedKubernetesVersion, latestStableKubernetesVersion, lowestMinorKubernetesVersion, latestPreviewKubernetesVersion);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ContainerServiceNewKubernetesVersionAvailableEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeContainerServiceNewKubernetesVersionAvailableEventData(document.RootElement);
        }

        internal partial class ContainerServiceNewKubernetesVersionAvailableEventDataConverter : JsonConverter<ContainerServiceNewKubernetesVersionAvailableEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerServiceNewKubernetesVersionAvailableEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override ContainerServiceNewKubernetesVersionAvailableEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerServiceNewKubernetesVersionAvailableEventData(document.RootElement);
            }
        }
    }
}

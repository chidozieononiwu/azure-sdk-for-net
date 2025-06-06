// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersGcpOfferingMdeAutoProvisioning : IUtf8JsonSerializable, IJsonModel<DefenderForServersGcpOfferingMdeAutoProvisioning>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForServersGcpOfferingMdeAutoProvisioning>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderForServersGcpOfferingMdeAutoProvisioning>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersGcpOfferingMdeAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersGcpOfferingMdeAutoProvisioning)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Configuration);
#else
                using (JsonDocument document = JsonDocument.Parse(Configuration, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        DefenderForServersGcpOfferingMdeAutoProvisioning IJsonModel<DefenderForServersGcpOfferingMdeAutoProvisioning>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersGcpOfferingMdeAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersGcpOfferingMdeAutoProvisioning)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersGcpOfferingMdeAutoProvisioning(document.RootElement, options);
        }

        internal static DefenderForServersGcpOfferingMdeAutoProvisioning DeserializeDefenderForServersGcpOfferingMdeAutoProvisioning(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            BinaryData configuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderForServersGcpOfferingMdeAutoProvisioning(enabled, configuration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForServersGcpOfferingMdeAutoProvisioning>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersGcpOfferingMdeAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersGcpOfferingMdeAutoProvisioning)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderForServersGcpOfferingMdeAutoProvisioning IPersistableModel<DefenderForServersGcpOfferingMdeAutoProvisioning>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersGcpOfferingMdeAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDefenderForServersGcpOfferingMdeAutoProvisioning(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersGcpOfferingMdeAutoProvisioning)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForServersGcpOfferingMdeAutoProvisioning>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

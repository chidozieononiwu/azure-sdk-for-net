// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBreakFileLocksContent : IUtf8JsonSerializable, IJsonModel<NetAppVolumeBreakFileLocksContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeBreakFileLocksContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetAppVolumeBreakFileLocksContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBreakFileLocksContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBreakFileLocksContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ClientIP))
            {
                writer.WritePropertyName("clientIp"u8);
                writer.WriteStringValue(ClientIP.ToString());
            }
            if (Optional.IsDefined(ConfirmRunningDisruptiveOperation))
            {
                writer.WritePropertyName("confirmRunningDisruptiveOperation"u8);
                writer.WriteBooleanValue(ConfirmRunningDisruptiveOperation.Value);
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

        NetAppVolumeBreakFileLocksContent IJsonModel<NetAppVolumeBreakFileLocksContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBreakFileLocksContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumeBreakFileLocksContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeBreakFileLocksContent(document.RootElement, options);
        }

        internal static NetAppVolumeBreakFileLocksContent DeserializeNetAppVolumeBreakFileLocksContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress clientIP = default;
            bool? confirmRunningDisruptiveOperation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("confirmRunningDisruptiveOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confirmRunningDisruptiveOperation = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetAppVolumeBreakFileLocksContent(clientIP, confirmRunningDisruptiveOperation, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeBreakFileLocksContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBreakFileLocksContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetAppContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBreakFileLocksContent)} does not support writing '{options.Format}' format.");
            }
        }

        NetAppVolumeBreakFileLocksContent IPersistableModel<NetAppVolumeBreakFileLocksContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumeBreakFileLocksContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetAppVolumeBreakFileLocksContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumeBreakFileLocksContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumeBreakFileLocksContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamingJobStorageAccount : IUtf8JsonSerializable, IJsonModel<StreamingJobStorageAccount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobStorageAccount>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamingJobStorageAccount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobStorageAccount)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        StreamingJobStorageAccount IJsonModel<StreamingJobStorageAccount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobStorageAccount)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobStorageAccount(document.RootElement, options);
        }

        internal static StreamingJobStorageAccount DeserializeStreamingJobStorageAccount(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            string accountKey = default;
            StreamAnalyticsAuthenticationMode? authenticationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationMode = new StreamAnalyticsAuthenticationMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StreamingJobStorageAccount(accountName, accountKey, authenticationMode, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingJobStorageAccount>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStreamAnalyticsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobStorageAccount)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingJobStorageAccount IPersistableModel<StreamingJobStorageAccount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStreamingJobStorageAccount(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobStorageAccount)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobStorageAccount>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

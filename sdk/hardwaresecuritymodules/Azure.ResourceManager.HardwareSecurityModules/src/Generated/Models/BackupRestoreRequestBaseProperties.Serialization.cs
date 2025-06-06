// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    public partial class BackupRestoreRequestBaseProperties : IUtf8JsonSerializable, IJsonModel<BackupRestoreRequestBaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupRestoreRequestBaseProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupRestoreRequestBaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreRequestBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRestoreRequestBaseProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("azureStorageBlobContainerUri"u8);
            writer.WriteStringValue(AzureStorageBlobContainerUri.AbsoluteUri);
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
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

        BackupRestoreRequestBaseProperties IJsonModel<BackupRestoreRequestBaseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreRequestBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupRestoreRequestBaseProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRestoreRequestBaseProperties(document.RootElement, options);
        }

        internal static BackupRestoreRequestBaseProperties DeserializeBackupRestoreRequestBaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri azureStorageBlobContainerUri = default;
            string token = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureStorageBlobContainerUri"u8))
                {
                    azureStorageBlobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackupRestoreRequestBaseProperties(azureStorageBlobContainerUri, token, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupRestoreRequestBaseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreRequestBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHardwareSecurityModulesContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BackupRestoreRequestBaseProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BackupRestoreRequestBaseProperties IPersistableModel<BackupRestoreRequestBaseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupRestoreRequestBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBackupRestoreRequestBaseProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupRestoreRequestBaseProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupRestoreRequestBaseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

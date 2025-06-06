// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedMongoDBCollectionResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedMongoDBCollectionResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedMongoDBCollectionResourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExtendedMongoDBCollectionResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedMongoDBCollectionResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedMongoDBCollectionResourceInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Rid))
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("_ts"u8);
                writer.WriteNumberValue(Timestamp.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("_etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
        }

        ExtendedMongoDBCollectionResourceInfo IJsonModel<ExtendedMongoDBCollectionResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedMongoDBCollectionResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedMongoDBCollectionResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedMongoDBCollectionResourceInfo(document.RootElement, options);
        }

        internal static ExtendedMongoDBCollectionResourceInfo DeserializeExtendedMongoDBCollectionResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string rid = default;
            float? ts = default;
            ETag? etag = default;
            string id = default;
            IDictionary<string, string> shardKey = default;
            IList<MongoDBIndex> indexes = default;
            int? analyticalStorageTtl = default;
            ResourceRestoreParameters restoreParameters = default;
            CosmosDBAccountCreateMode? createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    shardKey = dictionary;
                    continue;
                }
                if (property.NameEquals("indexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MongoDBIndex> array = new List<MongoDBIndex>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBIndex.DeserializeMongoDBIndex(item, options));
                    }
                    indexes = array;
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExtendedMongoDBCollectionResourceInfo(
                id,
                shardKey ?? new ChangeTrackingDictionary<string, string>(),
                indexes ?? new ChangeTrackingList<MongoDBIndex>(),
                analyticalStorageTtl,
                restoreParameters,
                createMode,
                serializedAdditionalRawData,
                rid,
                ts,
                etag);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  _rid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Rid))
                {
                    builder.Append("  _rid: ");
                    if (Rid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Rid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Rid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Timestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  _ts: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Timestamp))
                {
                    builder.Append("  _ts: ");
                    builder.AppendLine($"'{Timestamp.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ETag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  _etag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ETag))
                {
                    builder.Append("  _etag: ");
                    builder.AppendLine($"'{ETag.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CollectionName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CollectionName))
                {
                    builder.Append("  id: ");
                    if (CollectionName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CollectionName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CollectionName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ShardKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  shardKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ShardKey))
                {
                    if (ShardKey.Any())
                    {
                        builder.Append("  shardKey: ");
                        builder.AppendLine("{");
                        foreach (var item in ShardKey)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Indexes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  indexes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Indexes))
                {
                    if (Indexes.Any())
                    {
                        builder.Append("  indexes: ");
                        builder.AppendLine("[");
                        foreach (var item in Indexes)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  indexes: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AnalyticalStorageTtl), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  analyticalStorageTtl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AnalyticalStorageTtl))
                {
                    builder.Append("  analyticalStorageTtl: ");
                    builder.AppendLine($"{AnalyticalStorageTtl.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RestoreParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  restoreParameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RestoreParameters))
                {
                    builder.Append("  restoreParameters: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RestoreParameters, options, 2, false, "  restoreParameters: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreateMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  createMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreateMode))
                {
                    builder.Append("  createMode: ");
                    builder.AppendLine($"'{CreateMode.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ExtendedMongoDBCollectionResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedMongoDBCollectionResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCosmosDBContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedMongoDBCollectionResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ExtendedMongoDBCollectionResourceInfo IPersistableModel<ExtendedMongoDBCollectionResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedMongoDBCollectionResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExtendedMongoDBCollectionResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedMongoDBCollectionResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedMongoDBCollectionResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

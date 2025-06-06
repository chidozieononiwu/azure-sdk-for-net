// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SelfHelp
{
    public partial class SelfHelpSimplifiedSolutionResource : IJsonModel<SelfHelpSimplifiedSolutionData>
    {
        private static SelfHelpSimplifiedSolutionData s_dataDeserializationInstance;
        private static SelfHelpSimplifiedSolutionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<SelfHelpSimplifiedSolutionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SelfHelpSimplifiedSolutionData>)Data).Write(writer, options);

        SelfHelpSimplifiedSolutionData IJsonModel<SelfHelpSimplifiedSolutionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SelfHelpSimplifiedSolutionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<SelfHelpSimplifiedSolutionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SelfHelpSimplifiedSolutionData>(Data, options, AzureResourceManagerSelfHelpContext.Default);

        SelfHelpSimplifiedSolutionData IPersistableModel<SelfHelpSimplifiedSolutionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SelfHelpSimplifiedSolutionData>(data, options, AzureResourceManagerSelfHelpContext.Default);

        string IPersistableModel<SelfHelpSimplifiedSolutionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SelfHelpSimplifiedSolutionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork
{
    internal class MobileNetworkServiceOperationSource : IOperationSource<MobileNetworkServiceResource>
    {
        private readonly ArmClient _client;

        internal MobileNetworkServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        MobileNetworkServiceResource IOperationSource<MobileNetworkServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MobileNetworkServiceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMobileNetworkContext.Default);
            return new MobileNetworkServiceResource(_client, data);
        }

        async ValueTask<MobileNetworkServiceResource> IOperationSource<MobileNetworkServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MobileNetworkServiceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMobileNetworkContext.Default);
            return await Task.FromResult(new MobileNetworkServiceResource(_client, data)).ConfigureAwait(false);
        }
    }
}

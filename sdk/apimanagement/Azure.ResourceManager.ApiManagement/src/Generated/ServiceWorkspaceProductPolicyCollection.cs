// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceWorkspaceProductPolicyResource"/> and their operations.
    /// Each <see cref="ServiceWorkspaceProductPolicyResource"/> in the collection will belong to the same instance of <see cref="ServiceWorkspaceProductResource"/>.
    /// To get a <see cref="ServiceWorkspaceProductPolicyCollection"/> instance call the GetServiceWorkspaceProductPolicies method from an instance of <see cref="ServiceWorkspaceProductResource"/>.
    /// </summary>
    public partial class ServiceWorkspaceProductPolicyCollection : ArmCollection, IEnumerable<ServiceWorkspaceProductPolicyResource>, IAsyncEnumerable<ServiceWorkspaceProductPolicyResource>
    {
        private readonly ClientDiagnostics _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics;
        private readonly WorkspaceProductPolicyRestOperations _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceProductPolicyCollection"/> class for mocking. </summary>
        protected ServiceWorkspaceProductPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceProductPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceWorkspaceProductPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceWorkspaceProductPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceWorkspaceProductPolicyResource.ResourceType, out string serviceWorkspaceProductPolicyWorkspaceProductPolicyApiVersion);
            _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient = new WorkspaceProductPolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceProductPolicyWorkspaceProductPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceWorkspaceProductResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceWorkspaceProductResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates policy configuration for the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspaceProductPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PolicyName policyId, PolicyContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics.CreateScope("ServiceWorkspaceProductPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceWorkspaceProductPolicyResource>(Response.FromValue(new ServiceWorkspaceProductPolicyResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates policy configuration for the Product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="data"> The policy contents to apply. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspaceProductPolicyResource> CreateOrUpdate(WaitUntil waitUntil, PolicyName policyId, PolicyContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics.CreateScope("ServiceWorkspaceProductPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, data, ifMatch, cancellationToken);
                var uri = _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceWorkspaceProductPolicyResource>(Response.FromValue(new ServiceWorkspaceProductPolicyResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceWorkspaceProductPolicyResource>> GetAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics.CreateScope("ServiceWorkspaceProductPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceProductPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceWorkspaceProductPolicyResource> Get(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics.CreateScope("ServiceWorkspaceProductPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceProductPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_ListByProduct</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceWorkspaceProductPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceWorkspaceProductPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ServiceWorkspaceProductPolicyResource(Client, PolicyContractData.DeserializePolicyContractData(e)), _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics, Pipeline, "ServiceWorkspaceProductPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get the policy configuration at the Product level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_ListByProduct</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceWorkspaceProductPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceWorkspaceProductPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ServiceWorkspaceProductPolicyResource(Client, PolicyContractData.DeserializePolicyContractData(e)), _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics, Pipeline, "ServiceWorkspaceProductPolicyCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics.CreateScope("ServiceWorkspaceProductPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics.CreateScope("ServiceWorkspaceProductPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ServiceWorkspaceProductPolicyResource>> GetIfExistsAsync(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics.CreateScope("ServiceWorkspaceProductPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceProductPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceProductPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/products/{productId}/policies/{policyId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceProductPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceProductPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyId"> The identifier of the Policy. </param>
        /// <param name="format"> Policy Export Format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ServiceWorkspaceProductPolicyResource> GetIfExists(PolicyName policyId, PolicyExportFormat? format = null, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceWorkspaceProductPolicyWorkspaceProductPolicyClientDiagnostics.CreateScope("ServiceWorkspaceProductPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceProductPolicyWorkspaceProductPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, policyId, format, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceProductPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceProductPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceWorkspaceProductPolicyResource> IEnumerable<ServiceWorkspaceProductPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceWorkspaceProductPolicyResource> IAsyncEnumerable<ServiceWorkspaceProductPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

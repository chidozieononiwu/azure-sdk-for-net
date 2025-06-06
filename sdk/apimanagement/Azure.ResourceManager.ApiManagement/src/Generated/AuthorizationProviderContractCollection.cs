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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="AuthorizationProviderContractResource"/> and their operations.
    /// Each <see cref="AuthorizationProviderContractResource"/> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource"/>.
    /// To get an <see cref="AuthorizationProviderContractCollection"/> instance call the GetAuthorizationProviderContracts method from an instance of <see cref="ApiManagementServiceResource"/>.
    /// </summary>
    public partial class AuthorizationProviderContractCollection : ArmCollection, IEnumerable<AuthorizationProviderContractResource>, IAsyncEnumerable<AuthorizationProviderContractResource>
    {
        private readonly ClientDiagnostics _authorizationProviderContractAuthorizationProviderClientDiagnostics;
        private readonly AuthorizationProviderRestOperations _authorizationProviderContractAuthorizationProviderRestClient;

        /// <summary> Initializes a new instance of the <see cref="AuthorizationProviderContractCollection"/> class for mocking. </summary>
        protected AuthorizationProviderContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationProviderContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AuthorizationProviderContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _authorizationProviderContractAuthorizationProviderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", AuthorizationProviderContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AuthorizationProviderContractResource.ResourceType, out string authorizationProviderContractAuthorizationProviderApiVersion);
            _authorizationProviderContractAuthorizationProviderRestClient = new AuthorizationProviderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, authorizationProviderContractAuthorizationProviderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates authorization provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationProviderId"> Identifier of the authorization provider. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationProviderId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AuthorizationProviderContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationProviderId, AuthorizationProviderContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationProviderId, nameof(authorizationProviderId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _authorizationProviderContractAuthorizationProviderRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _authorizationProviderContractAuthorizationProviderRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<AuthorizationProviderContractResource>(Response.FromValue(new AuthorizationProviderContractResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates authorization provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationProviderId"> Identifier of the authorization provider. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationProviderId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AuthorizationProviderContractResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationProviderId, AuthorizationProviderContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationProviderId, nameof(authorizationProviderId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _authorizationProviderContractAuthorizationProviderRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, data, ifMatch, cancellationToken);
                var uri = _authorizationProviderContractAuthorizationProviderRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<AuthorizationProviderContractResource>(Response.FromValue(new AuthorizationProviderContractResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the details of the authorization provider specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationProviderId"> Identifier of the authorization provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationProviderId"/> is null. </exception>
        public virtual async Task<Response<AuthorizationProviderContractResource>> GetAsync(string authorizationProviderId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationProviderId, nameof(authorizationProviderId));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _authorizationProviderContractAuthorizationProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the authorization provider specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationProviderId"> Identifier of the authorization provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationProviderId"/> is null. </exception>
        public virtual Response<AuthorizationProviderContractResource> Get(string authorizationProviderId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationProviderId, nameof(authorizationProviderId));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractCollection.Get");
            scope.Start();
            try
            {
                var response = _authorizationProviderContractAuthorizationProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of authorization providers defined within a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AuthorizationProviderContractResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AuthorizationProviderContractResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _authorizationProviderContractAuthorizationProviderRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _authorizationProviderContractAuthorizationProviderRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AuthorizationProviderContractResource(Client, AuthorizationProviderContractData.DeserializeAuthorizationProviderContractData(e)), _authorizationProviderContractAuthorizationProviderClientDiagnostics, Pipeline, "AuthorizationProviderContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of authorization providers defined within a service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AuthorizationProviderContractResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AuthorizationProviderContractResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _authorizationProviderContractAuthorizationProviderRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _authorizationProviderContractAuthorizationProviderRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AuthorizationProviderContractResource(Client, AuthorizationProviderContractData.DeserializeAuthorizationProviderContractData(e)), _authorizationProviderContractAuthorizationProviderClientDiagnostics, Pipeline, "AuthorizationProviderContractCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationProviderId"> Identifier of the authorization provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationProviderId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationProviderId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationProviderId, nameof(authorizationProviderId));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _authorizationProviderContractAuthorizationProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationProviderId"> Identifier of the authorization provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationProviderId"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationProviderId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationProviderId, nameof(authorizationProviderId));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _authorizationProviderContractAuthorizationProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationProviderId"> Identifier of the authorization provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationProviderId"/> is null. </exception>
        public virtual async Task<NullableResponse<AuthorizationProviderContractResource>> GetIfExistsAsync(string authorizationProviderId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationProviderId, nameof(authorizationProviderId));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _authorizationProviderContractAuthorizationProviderRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AuthorizationProviderContractResource>(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderContractResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/authorizationProviders/{authorizationProviderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AuthorizationProvider_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AuthorizationProviderContractResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="authorizationProviderId"> Identifier of the authorization provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationProviderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationProviderId"/> is null. </exception>
        public virtual NullableResponse<AuthorizationProviderContractResource> GetIfExists(string authorizationProviderId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationProviderId, nameof(authorizationProviderId));

            using var scope = _authorizationProviderContractAuthorizationProviderClientDiagnostics.CreateScope("AuthorizationProviderContractCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _authorizationProviderContractAuthorizationProviderRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, authorizationProviderId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AuthorizationProviderContractResource>(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AuthorizationProviderContractResource> IEnumerable<AuthorizationProviderContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AuthorizationProviderContractResource> IAsyncEnumerable<AuthorizationProviderContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

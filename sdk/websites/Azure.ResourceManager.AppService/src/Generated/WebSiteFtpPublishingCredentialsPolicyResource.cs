// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WebSiteFtpPublishingCredentialsPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WebSiteFtpPublishingCredentialsPolicyResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWebSiteFtpPublishingCredentialsPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource"/> using the GetWebSiteFtpPublishingCredentialsPolicy method.
    /// </summary>
    public partial class WebSiteFtpPublishingCredentialsPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteFtpPublishingCredentialsPolicyResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteFtpPublishingCredentialsPolicyWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteFtpPublishingCredentialsPolicyWebAppsRestClient;
        private readonly CsmPublishingCredentialsPoliciesEntityData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/basicPublishingCredentialsPolicies";

        /// <summary> Initializes a new instance of the <see cref="WebSiteFtpPublishingCredentialsPolicyResource"/> class for mocking. </summary>
        protected WebSiteFtpPublishingCredentialsPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteFtpPublishingCredentialsPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteFtpPublishingCredentialsPolicyResource(ArmClient client, CsmPublishingCredentialsPoliciesEntityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteFtpPublishingCredentialsPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteFtpPublishingCredentialsPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteFtpPublishingCredentialsPolicyWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteFtpPublishingCredentialsPolicyWebAppsApiVersion);
            _webSiteFtpPublishingCredentialsPolicyWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteFtpPublishingCredentialsPolicyWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CsmPublishingCredentialsPoliciesEntityData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Returns whether FTP is allowed on the site or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetFtpAllowed</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteFtpPublishingCredentialsPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WebSiteFtpPublishingCredentialsPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteFtpPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("WebSiteFtpPublishingCredentialsPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteFtpPublishingCredentialsPolicyWebAppsRestClient.GetFtpAllowedAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteFtpPublishingCredentialsPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Returns whether FTP is allowed on the site or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetFtpAllowed</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteFtpPublishingCredentialsPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebSiteFtpPublishingCredentialsPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteFtpPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("WebSiteFtpPublishingCredentialsPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteFtpPublishingCredentialsPolicyWebAppsRestClient.GetFtpAllowed(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteFtpPublishingCredentialsPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates whether FTP is allowed on the site or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_UpdateFtpAllowed</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteFtpPublishingCredentialsPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="CsmPublishingCredentialsPoliciesEntityData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebSiteFtpPublishingCredentialsPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteFtpPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("WebSiteFtpPublishingCredentialsPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webSiteFtpPublishingCredentialsPolicyWebAppsRestClient.UpdateFtpAllowedAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _webSiteFtpPublishingCredentialsPolicyWebAppsRestClient.CreateUpdateFtpAllowedRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation<WebSiteFtpPublishingCredentialsPolicyResource>(Response.FromValue(new WebSiteFtpPublishingCredentialsPolicyResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Description for Updates whether FTP is allowed on the site or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/basicPublishingCredentialsPolicies/ftp</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_UpdateFtpAllowed</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebSiteFtpPublishingCredentialsPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The <see cref="CsmPublishingCredentialsPoliciesEntityData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebSiteFtpPublishingCredentialsPolicyResource> CreateOrUpdate(WaitUntil waitUntil, CsmPublishingCredentialsPoliciesEntityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _webSiteFtpPublishingCredentialsPolicyWebAppsClientDiagnostics.CreateScope("WebSiteFtpPublishingCredentialsPolicyResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webSiteFtpPublishingCredentialsPolicyWebAppsRestClient.UpdateFtpAllowed(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var uri = _webSiteFtpPublishingCredentialsPolicyWebAppsRestClient.CreateUpdateFtpAllowedRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new AppServiceArmOperation<WebSiteFtpPublishingCredentialsPolicyResource>(Response.FromValue(new WebSiteFtpPublishingCredentialsPolicyResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
    }
}

// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConsumerInvitationsOperations.
    /// </summary>
    public static partial class ConsumerInvitationsOperationsExtensions
    {
            /// <summary>
            /// List the invitations
            /// </summary>
            /// <remarks>
            /// Lists invitations
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// The continuation token
            /// </param>
            public static IPage<ConsumerInvitation> ListInvitations(this IConsumerInvitationsOperations operations, string skipToken = default(string))
            {
                return operations.ListInvitationsAsync(skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the invitations
            /// </summary>
            /// <remarks>
            /// Lists invitations
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skipToken'>
            /// The continuation token
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConsumerInvitation>> ListInvitationsAsync(this IConsumerInvitationsOperations operations, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListInvitationsWithHttpMessagesAsync(skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the invitation identified by invitationId
            /// </summary>
            /// <remarks>
            /// Get an invitation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the invitation
            /// </param>
            /// <param name='invitationId'>
            /// An invitation id
            /// </param>
            public static ConsumerInvitation Get(this IConsumerInvitationsOperations operations, string location, string invitationId)
            {
                return operations.GetAsync(location, invitationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the invitation identified by invitationId
            /// </summary>
            /// <remarks>
            /// Get an invitation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the invitation
            /// </param>
            /// <param name='invitationId'>
            /// An invitation id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConsumerInvitation> GetAsync(this IConsumerInvitationsOperations operations, string location, string invitationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, invitationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Rejects the invitation identified by invitationId
            /// </summary>
            /// <remarks>
            /// Reject an invitation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the invitation
            /// </param>
            /// <param name='invitation'>
            /// An invitation payload
            /// </param>
            public static ConsumerInvitation RejectInvitation(this IConsumerInvitationsOperations operations, string location, ConsumerInvitation invitation)
            {
                return operations.RejectInvitationAsync(location, invitation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Rejects the invitation identified by invitationId
            /// </summary>
            /// <remarks>
            /// Reject an invitation
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the invitation
            /// </param>
            /// <param name='invitation'>
            /// An invitation payload
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConsumerInvitation> RejectInvitationAsync(this IConsumerInvitationsOperations operations, string location, ConsumerInvitation invitation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RejectInvitationWithHttpMessagesAsync(location, invitation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the invitations
            /// </summary>
            /// <remarks>
            /// Lists invitations
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConsumerInvitation> ListInvitationsNext(this IConsumerInvitationsOperations operations, string nextPageLink)
            {
                return operations.ListInvitationsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the invitations
            /// </summary>
            /// <remarks>
            /// Lists invitations
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConsumerInvitation>> ListInvitationsNextAsync(this IConsumerInvitationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListInvitationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

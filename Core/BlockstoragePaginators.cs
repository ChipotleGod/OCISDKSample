/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Collections.Generic;
using System.Threading;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.CoreService.Models;

namespace Oci.CoreService
{
    /// <summary>
    /// Collection of helper methods that can be used to provide an enumerator interface
    /// to any list operations of Blockstorage where multiple pages of data may be fetched.
    /// Two styles of enumerators are supported:
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Enumerating over the Response objects returned by the list operation. These are referred to as ResponseEnumerators, and the methods are suffixed with ResponseEnumerator. For example: listUsersResponseEnumerator.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// Enumerating over the resources/records being listed. These are referred to as RecordEnumerators, and the methods are suffixed with RecordEnumerator. For example: listUsersRecordEnumerator.
    /// </description>
    /// </item>
    /// </list>
    /// These enumerators abstract away the need to write code to manually handle pagination via looping and using the page tokens.
    /// They will automatically fetch more data from the service when required.
    /// <br/>
    /// <br/>
    /// As an example, if we were using the ListUsers operation in IdentityService, then the iterator returned by calling a
    /// ResponseEnumerator method would iterate over the ListUsersResponse objects returned by each ListUsers call, whereas the enumerables
    /// returned by calling a RecordEnumerator method would iterate over the User records and we don't have to deal with ListUsersResponse objects at all.
    /// In either case, pagination will be automatically handled so we can iterate until there are no more responses or no more resources/records available.
    /// </summary>
    public class BlockstoragePaginators
    {
        private readonly BlockstorageClient client;

        public BlockstoragePaginators(BlockstorageClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the GetVolumeBackupPolicyAssetAssignment operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<GetVolumeBackupPolicyAssetAssignmentResponse> GetVolumeBackupPolicyAssetAssignmentResponseEnumerator(GetVolumeBackupPolicyAssetAssignmentRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<GetVolumeBackupPolicyAssetAssignmentRequest, GetVolumeBackupPolicyAssetAssignmentResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.GetVolumeBackupPolicyAssetAssignment(request, retryConfiguration, cancellationToken).Result
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the VolumeBackupPolicyAssignment objects
        /// contained in responses from the GetVolumeBackupPolicyAssetAssignment operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<VolumeBackupPolicyAssignment> GetVolumeBackupPolicyAssetAssignmentRecordEnumerator(GetVolumeBackupPolicyAssetAssignmentRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<GetVolumeBackupPolicyAssetAssignmentRequest, GetVolumeBackupPolicyAssetAssignmentResponse, VolumeBackupPolicyAssignment>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.GetVolumeBackupPolicyAssetAssignment(request, retryConfiguration, cancellationToken).Result,
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListBootVolumeBackups operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListBootVolumeBackupsResponse> ListBootVolumeBackupsResponseEnumerator(ListBootVolumeBackupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListBootVolumeBackupsRequest, ListBootVolumeBackupsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListBootVolumeBackups(request, retryConfiguration, cancellationToken).Result
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the BootVolumeBackup objects
        /// contained in responses from the ListBootVolumeBackups operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<BootVolumeBackup> ListBootVolumeBackupsRecordEnumerator(ListBootVolumeBackupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListBootVolumeBackupsRequest, ListBootVolumeBackupsResponse, BootVolumeBackup>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListBootVolumeBackups(request, retryConfiguration, cancellationToken).Result,
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListBootVolumes operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListBootVolumesResponse> ListBootVolumesResponseEnumerator(ListBootVolumesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListBootVolumesRequest, ListBootVolumesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListBootVolumes(request, retryConfiguration, cancellationToken).Result
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the BootVolume objects
        /// contained in responses from the ListBootVolumes operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<BootVolume> ListBootVolumesRecordEnumerator(ListBootVolumesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListBootVolumesRequest, ListBootVolumesResponse, BootVolume>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListBootVolumes(request, retryConfiguration, cancellationToken).Result,
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListVolumeBackupPolicies operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListVolumeBackupPoliciesResponse> ListVolumeBackupPoliciesResponseEnumerator(ListVolumeBackupPoliciesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListVolumeBackupPoliciesRequest, ListVolumeBackupPoliciesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumeBackupPolicies(request, retryConfiguration, cancellationToken).Result
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the VolumeBackupPolicy objects
        /// contained in responses from the ListVolumeBackupPolicies operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<VolumeBackupPolicy> ListVolumeBackupPoliciesRecordEnumerator(ListVolumeBackupPoliciesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListVolumeBackupPoliciesRequest, ListVolumeBackupPoliciesResponse, VolumeBackupPolicy>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumeBackupPolicies(request, retryConfiguration, cancellationToken).Result,
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListVolumeBackups operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListVolumeBackupsResponse> ListVolumeBackupsResponseEnumerator(ListVolumeBackupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListVolumeBackupsRequest, ListVolumeBackupsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumeBackups(request, retryConfiguration, cancellationToken).Result
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the VolumeBackup objects
        /// contained in responses from the ListVolumeBackups operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<VolumeBackup> ListVolumeBackupsRecordEnumerator(ListVolumeBackupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListVolumeBackupsRequest, ListVolumeBackupsResponse, VolumeBackup>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumeBackups(request, retryConfiguration, cancellationToken).Result,
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListVolumeGroupBackups operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListVolumeGroupBackupsResponse> ListVolumeGroupBackupsResponseEnumerator(ListVolumeGroupBackupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListVolumeGroupBackupsRequest, ListVolumeGroupBackupsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumeGroupBackups(request, retryConfiguration, cancellationToken).Result
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the VolumeGroupBackup objects
        /// contained in responses from the ListVolumeGroupBackups operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<VolumeGroupBackup> ListVolumeGroupBackupsRecordEnumerator(ListVolumeGroupBackupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListVolumeGroupBackupsRequest, ListVolumeGroupBackupsResponse, VolumeGroupBackup>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumeGroupBackups(request, retryConfiguration, cancellationToken).Result,
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListVolumeGroups operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListVolumeGroupsResponse> ListVolumeGroupsResponseEnumerator(ListVolumeGroupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListVolumeGroupsRequest, ListVolumeGroupsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumeGroups(request, retryConfiguration, cancellationToken).Result
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the VolumeGroup objects
        /// contained in responses from the ListVolumeGroups operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<VolumeGroup> ListVolumeGroupsRecordEnumerator(ListVolumeGroupsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListVolumeGroupsRequest, ListVolumeGroupsResponse, VolumeGroup>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumeGroups(request, retryConfiguration, cancellationToken).Result,
                response => response.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListVolumes operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListVolumesResponse> ListVolumesResponseEnumerator(ListVolumesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListVolumesRequest, ListVolumesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumes(request, retryConfiguration, cancellationToken).Result
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the Volume objects
        /// contained in responses from the ListVolumes operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<Volume> ListVolumesRecordEnumerator(ListVolumesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVolumes(request, retryConfiguration, cancellationToken).Result,
                response => response.Items
            );
        }

    }
}

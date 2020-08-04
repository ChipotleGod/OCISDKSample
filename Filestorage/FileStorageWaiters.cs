/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.FilestorageService.Models;
using Oci.FilestorageService.Requests;
using Oci.FilestorageService.Responses;

namespace Oci.FilestorageService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of FileStorage.
    /// </summary>
    public class FileStorageWaiters
    {
        private readonly FileStorageClient client;

        public  FileStorageWaiters(FileStorageClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetExportRequest, GetExportResponse> ForExport(GetExportRequest request, params Export.LifecycleStateEnum[] targetStates)
        {
            return this.ForExport(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetExportRequest, GetExportResponse> ForExport(GetExportRequest request, WaiterConfiguration config, params Export.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetExportRequest, GetExportResponse>(
                request,
                request => client.GetExport(request),
                response => targetStates.Contains(response.Export.LifecycleState.Value),
                targetStates.Contains(Export.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetExportRequest, GetExportResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetExportSetRequest, GetExportSetResponse> ForExportSet(GetExportSetRequest request, params ExportSet.LifecycleStateEnum[] targetStates)
        {
            return this.ForExportSet(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetExportSetRequest, GetExportSetResponse> ForExportSet(GetExportSetRequest request, WaiterConfiguration config, params ExportSet.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetExportSetRequest, GetExportSetResponse>(
                request,
                request => client.GetExportSet(request),
                response => targetStates.Contains(response.ExportSet.LifecycleState.Value),
                targetStates.Contains(ExportSet.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetExportSetRequest, GetExportSetResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFileSystemRequest, GetFileSystemResponse> ForFileSystem(GetFileSystemRequest request, params FileSystem.LifecycleStateEnum[] targetStates)
        {
            return this.ForFileSystem(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFileSystemRequest, GetFileSystemResponse> ForFileSystem(GetFileSystemRequest request, WaiterConfiguration config, params FileSystem.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetFileSystemRequest, GetFileSystemResponse>(
                request,
                request => client.GetFileSystem(request),
                response => targetStates.Contains(response.FileSystem.LifecycleState.Value),
                targetStates.Contains(FileSystem.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetFileSystemRequest, GetFileSystemResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetMountTargetRequest, GetMountTargetResponse> ForMountTarget(GetMountTargetRequest request, params MountTarget.LifecycleStateEnum[] targetStates)
        {
            return this.ForMountTarget(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetMountTargetRequest, GetMountTargetResponse> ForMountTarget(GetMountTargetRequest request, WaiterConfiguration config, params MountTarget.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetMountTargetRequest, GetMountTargetResponse>(
                request,
                request => client.GetMountTarget(request),
                response => targetStates.Contains(response.MountTarget.LifecycleState.Value),
                targetStates.Contains(MountTarget.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetMountTargetRequest, GetMountTargetResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSnapshotRequest, GetSnapshotResponse> ForSnapshot(GetSnapshotRequest request, params Snapshot.LifecycleStateEnum[] targetStates)
        {
            return this.ForSnapshot(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSnapshotRequest, GetSnapshotResponse> ForSnapshot(GetSnapshotRequest request, WaiterConfiguration config, params Snapshot.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetSnapshotRequest, GetSnapshotResponse>(
                request,
                request => client.GetSnapshot(request),
                response => targetStates.Contains(response.Snapshot.LifecycleState.Value),
                targetStates.Contains(Snapshot.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetSnapshotRequest, GetSnapshotResponse>(config, agent);
        }
    }
}

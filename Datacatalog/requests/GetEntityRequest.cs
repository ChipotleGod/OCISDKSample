/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Requests
{
    public class GetEntityRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique catalog identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Unique data asset key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataAssetKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "dataAssetKey")]
        public string DataAssetKey { get; set; }
        
        /// <value>
        /// Unique entity key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "entityKey")]
        public string EntityKey { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in an entity response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "description")]
            Description,
            [EnumMember(Value = "dataAssetKey")]
            DataAssetKey,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "timeUpdated")]
            TimeUpdated,
            [EnumMember(Value = "createdById")]
            CreatedById,
            [EnumMember(Value = "updatedById")]
            UpdatedById,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "externalKey")]
            ExternalKey,
            [EnumMember(Value = "timeExternal")]
            TimeExternal,
            [EnumMember(Value = "timeStatusUpdated")]
            TimeStatusUpdated,
            [EnumMember(Value = "isLogical")]
            IsLogical,
            [EnumMember(Value = "isPartition")]
            IsPartition,
            [EnumMember(Value = "folderKey")]
            FolderKey,
            [EnumMember(Value = "typeKey")]
            TypeKey,
            [EnumMember(Value = "path")]
            Path,
            [EnumMember(Value = "harvestStatus")]
            HarvestStatus,
            [EnumMember(Value = "lastJobKey")]
            LastJobKey,
            [EnumMember(Value = "uri")]
            Uri,
            [EnumMember(Value = "properties")]
            Properties
        };

        /// <value>
        /// Specifies the fields to return in an entity response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields")]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
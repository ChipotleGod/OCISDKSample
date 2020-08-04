/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DataintegrationService.Models;

namespace Oci.DataintegrationService.Requests
{
    public class ListDependentObjectsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// DIS workspace id
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WorkspaceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "workspaceId")]
        public string WorkspaceId { get; set; }
        
        /// <value>
        /// DIS application key
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "applicationKey")]
        public string ApplicationKey { get; set; }
        
        /// <value>
        /// This parameter allows users to specify which fields to get for an object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields")]
        public System.Collections.Generic.List<string> Fields { get; set; }
        
        /// <value>
        /// This filter parameter can be used to filter by the name of the object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// This filter parameter can be used to filter by the identifier of the published object.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "identifier")]
        public System.Collections.Generic.List<string> Identifier { get; set; }
        
        /// <value>
        /// This filter parameter can be used to filter by the object type of the object.
        /// This parameter can be suffixed with an optional filter operator InSubtree.
        /// For DIS APIs we will filter based on type Task.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "type")]
        public System.Collections.Generic.List<string> Type { get; set; }
        
        /// <value>
        /// This is used in association with type parameter. If value is true,
        /// then type all sub types of the given type parameter is considered.
        /// If value is false, then sub types are not considered. Default is false.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "typeInSubtree")]
        public string TypeInSubtree { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        ///
        /// <value>
        /// This parameter is used to control the sort order.  Supported values are `ASC` (ascending) and `DESC` (descending).
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// This parameter is used to control the sort order.  Supported values are `ASC` (ascending) and `DESC` (descending).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        ///
        /// <value>
        /// This parameter allows users to specify a sort field.  Supported sort fields are `name`, `identifier`, `timeCreated`, and `timeUpdated`.  Default sort order is the descending order of `timeCreated` (most recently created objects at the top).  Sorting related parameters are ignored when parameter `query` is present (search operation and sorting order is by relevance score in descending order).
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIME_CREATED")]
            TimeCreated,
            [EnumMember(Value = "DISPLAY_NAME")]
            DisplayName
        };

        /// <value>
        /// This parameter allows users to specify a sort field.  Supported sort fields are `name`, `identifier`, `timeCreated`, and `timeUpdated`.  Default sort order is the descending order of `timeCreated` (most recently created objects at the top).  Sorting related parameters are ignored when parameter `query` is present (search operation and sorting order is by relevance score in descending order).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If
        /// you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Requests
{
    public class UpdateProjectRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/identifiers.htm) of the project.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "projectId")]
        public string ProjectId { get; set; }
        
        /// <value>
        /// Details for updating a project. You can update the `displayName`, `description`, `freeformTags`, and `definedTags` properties.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateProjectDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public UpdateProjectDetails UpdateProjectDetails { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call
        /// for a resource, set the `if-match` parameter to the value of the
        /// etag from a previous GET or POST response for that resource.
        /// The resource will be updated or deleted only if the `etag` you
        /// provide matches the resource's current `etag` value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
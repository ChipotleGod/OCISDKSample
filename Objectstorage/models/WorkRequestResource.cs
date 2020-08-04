/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ObjectstorageService.Models
{
    
    public class WorkRequestResource 
    {
                ///
        /// <value>
        /// The status of the work request.
        /// </value>
        ///
        public enum ActionTypeEnum {
            [EnumMember(Value = "CREATED")]
            Created,
            [EnumMember(Value = "UPDATED")]
            Updated,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "RELATED")]
            Related,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "READ")]
            Read,
            [EnumMember(Value = "WRITTEN")]
            Written
        };

        /// <value>
        /// The status of the work request.
        /// </value>
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionTypeEnum> ActionType { get; set; }

        /// <value>
        /// The resource type the work request affects.
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }

        /// <value>
        /// The resource type identifier.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <value>
        /// The URI path that you can use for a GET request to access the resource metadata.
        /// </value>
        [JsonProperty(PropertyName = "entityUri")]
        public string EntityUri { get; set; }

        /// <value>
        /// The metadata of the resource.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
    }
}

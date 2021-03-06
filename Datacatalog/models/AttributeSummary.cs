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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Summary of an entity attribute.
    /// </summary>
    public class AttributeSummary 
    {
        
        /// <value>
        /// Unique attribute key that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <value>
        /// A user-friendly display name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Detailed description of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The unique key of the parent entity.
        /// </value>
        [JsonProperty(PropertyName = "entityKey")]
        public string EntityKey { get; set; }

        /// <value>
        /// Unique external key of this attribute in the external source system.
        /// </value>
        [JsonProperty(PropertyName = "externalKey")]
        public string ExternalKey { get; set; }

        /// <value>
        /// Max allowed length of the attribute value.
        /// </value>
        [JsonProperty(PropertyName = "length")]
        public System.Nullable<long> Length { get; set; }

        /// <value>
        /// Property that identifies if this attribute can be assigned null values.
        /// </value>
        [JsonProperty(PropertyName = "isNullable")]
        public System.Nullable<bool> IsNullable { get; set; }

        /// <value>
        /// URI to the attribute instance in the API.
        /// </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <value>
        /// State of the attribute.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }

        /// <value>
        /// The date and time the attribute was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2019-03-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// Data type of the attribute as defined in the external source system.
        /// </value>
        [JsonProperty(PropertyName = "externalDataType")]
        public string ExternalDataType { get; set; }
    }
}

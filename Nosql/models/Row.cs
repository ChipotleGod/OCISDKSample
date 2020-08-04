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


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// The result of GetRow.
    /// </summary>
    public class Row 
    {
        
        /// <value>
        /// The map of values from a row.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.Dictionary<string, System.Object> Value { get; set; }

        /// <value>
        /// The expiration time of the row. A zero value indicates that
        /// the row does not expire. An RFC3339 formatted datetime
        /// string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeOfExpiration")]
        public System.Nullable<System.DateTime> TimeOfExpiration { get; set; }

        [JsonProperty(PropertyName = "usage")]
        public RequestUsage Usage { get; set; }
    }
}
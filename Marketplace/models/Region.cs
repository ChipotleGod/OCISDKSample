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


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// The model for regions supported by a listing and package.
    /// </summary>
    public class Region 
    {
        
        /// <value>
        /// The name of the region.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The code of the region.
        /// </value>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <value>
        /// Countries in the region.
        /// </value>
        [JsonProperty(PropertyName = "countries")]
        public System.Collections.Generic.List<Item> Countries { get; set; }
    }
}

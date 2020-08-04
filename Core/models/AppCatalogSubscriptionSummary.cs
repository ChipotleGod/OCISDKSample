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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// a subscription summary for a listing resource version.
    /// </summary>
    public class AppCatalogSubscriptionSummary 
    {
        
        /// <value>
        /// Name of the publisher who published this listing.
        /// </value>
        [JsonProperty(PropertyName = "publisherName")]
        public string PublisherName { get; set; }

        /// <value>
        /// The ocid of the listing resource.
        /// </value>
        [JsonProperty(PropertyName = "listingId")]
        public string ListingId { get; set; }

        /// <value>
        /// Listing resource version.
        /// </value>
        [JsonProperty(PropertyName = "listingResourceVersion")]
        public string ListingResourceVersion { get; set; }

        /// <value>
        /// Listing resource id.
        /// </value>
        [JsonProperty(PropertyName = "listingResourceId")]
        public string ListingResourceId { get; set; }

        /// <value>
        /// The display name of the listing.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The short summary to the listing.
        /// </value>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        /// <value>
        /// The compartmentID of the subscription.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// Date and time at which the subscription was created, in [RFC3339](https://tools.ietf.org/html/rfc3339) format.
        /// Example: 2018-03-20T12:32:53.532Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
    }
}

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
    /// The model for pricing.
    /// </summary>
    public class PricingModel 
    {
        
        /// <value>
        /// The type of the pricing model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PricingTypeEnum> Type { get; set; }

        /// <value>
        /// The type of pricing for a PAYGO model, eg PER_OCPU_LINEAR, PER_OCPU_MIN_BILLING, PER_INSTANCE.  Null if type is not PAYGO.
        /// </value>
        [JsonProperty(PropertyName = "payGoStrategy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PricingStrategyEnum> PayGoStrategy { get; set; }

        /// <value>
        /// The currency of the pricing model.
        /// </value>
        [JsonProperty(PropertyName = "currency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PricingCurrencyEnum> Currency { get; set; }

        /// <value>
        /// The pricing rate.
        /// </value>
        [JsonProperty(PropertyName = "rate")]
        public System.Nullable<decimal> Rate { get; set; }
    }
}

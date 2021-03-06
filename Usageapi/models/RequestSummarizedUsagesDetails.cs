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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// details for the '/usage' query
    /// </summary>
    public class RequestSummarizedUsagesDetails 
    {
        
        /// <value>
        /// tenant id
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantId is required.")]
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <value>
        /// The start time of the usage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUsageStarted is required.")]
        [JsonProperty(PropertyName = "timeUsageStarted")]
        public System.Nullable<System.DateTime> TimeUsageStarted { get; set; }

        /// <value>
        /// The end time of the usage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUsageEnded is required.")]
        [JsonProperty(PropertyName = "timeUsageEnded")]
        public System.Nullable<System.DateTime> TimeUsageEnded { get; set; }
        ///
        /// <value>
        /// The granularity of the usage.
        /// HOURLY - Hourly aggregation of data
        /// DAILY - Daily aggregation of data
        /// MONTHLY - Monthly aggregation of data
        /// TOTAL - Not Supported Yet
        /// 
        /// </value>
        ///
        public enum GranularityEnum {
            [EnumMember(Value = "HOURLY")]
            Hourly,
            [EnumMember(Value = "DAILY")]
            Daily,
            [EnumMember(Value = "MONTHLY")]
            Monthly,
            [EnumMember(Value = "TOTAL")]
            Total
        };

        /// <value>
        /// The granularity of the usage.
        /// HOURLY - Hourly aggregation of data
        /// DAILY - Daily aggregation of data
        /// MONTHLY - Monthly aggregation of data
        /// TOTAL - Not Supported Yet
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Granularity is required.")]
        [JsonProperty(PropertyName = "granularity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<GranularityEnum> Granularity { get; set; }
        ///
        /// <value>
        /// The type of query of the usage.
        /// Usage - Query the usage data.
        /// Cost - Query the cost / billing data.
        /// 
        /// </value>
        ///
        public enum QueryTypeEnum {
            [EnumMember(Value = "USAGE")]
            Usage,
            [EnumMember(Value = "COST")]
            Cost
        };

        /// <value>
        /// The type of query of the usage.
        /// Usage - Query the usage data.
        /// Cost - Query the cost / billing data.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<QueryTypeEnum> QueryType { get; set; }

        /// <value>
        /// Aggregate the result by.
        /// Example:   [&quot;service&quot;]
        /// </value>
        [JsonProperty(PropertyName = "groupBy")]
        public System.Collections.Generic.List<string> GroupBy { get; set; }

        /// <value>
        /// The depth level of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentDepth")]
        public System.Nullable<decimal> CompartmentDepth { get; set; }

        [JsonProperty(PropertyName = "filter")]
        public Filter Filter { get; set; }
    }
}

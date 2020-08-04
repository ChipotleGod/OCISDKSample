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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// An access control rule condition that requires a match on the specified source VCN and IP address range.
    /// This condition must be used only in conjunction with `SourceVcnIdCondition`.
    /// 
    /// </summary>
    public class SourceVcnIpAddressCondition : RuleCondition
    {
        
        /// <value>
        /// An IPv4 address range that the original client IP address (in the context of the specified VCN) of an
        /// incoming packet must match.
        /// <br/>
        /// The service accepts only classless inter-domain routing (CIDR) format (x.x.x.x/y) strings.
        /// <br/>
        /// Specify 0.0.0.0/0 to match all incoming traffic in the customer VCN.
        /// <br/>
        /// Example: &quot;10.10.1.0/24&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeValue is required.")]
        [JsonProperty(PropertyName = "attributeValue")]
        public string AttributeValue { get; set; }
    }
}

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
    /// A public IP prefix and its details. With a public virtual circuit, the customer
    /// specifies the customer-owned public IP prefixes to advertise across the connection.
    /// For more information, see [FastConnect Overview](https://docs.cloud.oracle.com/Content/Network/Concepts/fastconnect.htm).
    /// 
    /// </summary>
    public class VirtualCircuitPublicPrefix 
    {
        
        /// <value>
        /// Publix IP prefix (CIDR) that the customer specified.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CidrBlock is required.")]
        [JsonProperty(PropertyName = "cidrBlock")]
        public string CidrBlock { get; set; }
        ///
        /// <value>
        /// Oracle must verify that the customer owns the public IP prefix before traffic
        /// for that prefix can flow across the virtual circuit. Verification can take a
        /// few business days. `IN_PROGRESS` means Oracle is verifying the prefix. `COMPLETED`
        /// means verification succeeded. `FAILED` means verification failed and traffic for
        /// this prefix will not flow across the connection.
        /// 
        /// </value>
        ///
        public enum VerificationStateEnum {
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "COMPLETED")]
            Completed,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Oracle must verify that the customer owns the public IP prefix before traffic
        /// for that prefix can flow across the virtual circuit. Verification can take a
        /// few business days. `IN_PROGRESS` means Oracle is verifying the prefix. `COMPLETED`
        /// means verification succeeded. `FAILED` means verification failed and traffic for
        /// this prefix will not flow across the connection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VerificationState is required.")]
        [JsonProperty(PropertyName = "verificationState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<VerificationStateEnum> VerificationState { get; set; }
    }
}
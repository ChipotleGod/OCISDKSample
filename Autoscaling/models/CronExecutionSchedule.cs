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


namespace Oci.AutoscalingService.Models
{
    /// <summary>
    /// Specifies the execution schedule of CRON type.
    /// 
    /// </summary>
    public class CronExecutionSchedule : ExecutionSchedule
    {
        
        /// <value>
        /// The value representing the execution schedule, as defined by cron format.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Expression is required.")]
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }
    }
}

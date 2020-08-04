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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// The Autonomous Database preview version. Note that preview version software is only available for databases on [shared Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adboverview.htm#AEI).
    /// 
    /// </summary>
    public class AutonomousDbPreviewVersionSummary 
    {
        
        /// <value>
        /// A valid Autonomous Database preview version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Version is required.")]
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <value>
        /// The date and time when the preview version availability begins.
        /// </value>
        [JsonProperty(PropertyName = "timePreviewBegin")]
        public System.Nullable<System.DateTime> TimePreviewBegin { get; set; }

        /// <value>
        /// The date and time when the preview version availability ends.
        /// </value>
        [JsonProperty(PropertyName = "timePreviewEnd")]
        public System.Nullable<System.DateTime> TimePreviewEnd { get; set; }
        ///
        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// 
        /// </value>
        ///
        public enum DbWorkloadEnum {
            [EnumMember(Value = "OLTP")]
            Oltp,
            [EnumMember(Value = "DW")]
            Dw
        };

        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbWorkload")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbWorkloadEnum> DbWorkload { get; set; }

        /// <value>
        /// A URL that points to a detailed description of the preview version.
        /// </value>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }
    }
}

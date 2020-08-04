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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// The Maintenance Policy for the DB System.
    /// 
    /// </summary>
    public class UpdateMaintenanceDetails 
    {
        
        /// <value>
        /// The start of the 2 hour maintenance window.
        /// <br/>
        /// This string is of the format: \"{day-of-week} {time-of-day}\".
        /// <br/>
        /// \"{day-of-week}\" is a case-insensitive string like \"mon\", \"tue\", &c.
        /// <br/>
        /// \"{time-of-day}\" is the \"Time\" portion of an RFC3339-formatted timestamp. Any second or sub-second time data will be truncated to zero.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "windowStartTime")]
        public string WindowStartTime { get; set; }
    }
}

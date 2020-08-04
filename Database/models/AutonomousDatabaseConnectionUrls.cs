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
    /// The URLs for accessing Oracle Application Express (APEX) and SQL Developer Web with a browser from a Compute instance within your VCN or that has a direct connection to your VCN. Note that these URLs are provided by the console only for databases on [dedicated Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adbddoverview.htm).
    /// <br/>
    /// Example: {&quot;sqlDevWebUrl&quot;: &quot;https://<hostname>/ords...&quot;, &quot;apexUrl&quot;, &quot;https://<hostname>/ords...&quot;}
    /// </summary>
    public class AutonomousDatabaseConnectionUrls 
    {
        
        /// <value>
        /// Oracle SQL Developer Web URL.
        /// </value>
        [JsonProperty(PropertyName = "sqlDevWebUrl")]
        public string SqlDevWebUrl { get; set; }

        /// <value>
        /// Oracle Application Express (APEX) URL.
        /// </value>
        [JsonProperty(PropertyName = "apexUrl")]
        public string ApexUrl { get; set; }

        /// <value>
        /// Oracle Machine Learning user management URL.
        /// </value>
        [JsonProperty(PropertyName = "machineLearningUserManagementUrl")]
        public string MachineLearningUserManagementUrl { get; set; }
    }
}

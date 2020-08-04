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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The properties that define a metric.
    /// For information about metrics, see [Metrics Overview](https://docs.cloud.oracle.com/iaas/Content/Monitoring/Concepts/monitoringoverview.htm#MetricsOverview).
    /// 
    /// </summary>
    public class Metric 
    {
        
        /// <value>
        /// The name of the metric.
        /// <br/>
        /// Example: CpuUtilization
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The source service or application emitting the metric.
        /// <br/>
        /// Example: oci_computeagent
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }

        /// <value>
        /// Resource group provided with the posted metric. A resource group is a custom string that can be used as a filter. Only one resource group can be applied per metric.
        /// A valid resourceGroup value starts with an alphabetical character and includes only alphanumeric characters, periods (.), underscores (_), hyphens (-), and dollar signs ($).
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: frontend-fleet
        /// </value>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing
        /// the resources monitored by the metric.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// Qualifiers provided in a metric definition. Available dimensions vary by metric namespace.
        /// Each dimension takes the form of a key-value pair.
        /// <br/>
        /// Example: &quot;resourceId&quot;: &quot;ocid1.instance.region1.phx.exampleuniqueID&quot;
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }
    }
}

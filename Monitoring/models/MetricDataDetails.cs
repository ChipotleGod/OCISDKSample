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
    /// A metric object containing raw metric data points to be posted to the Monitoring service. 
    /// 
    /// </summary>
    public class MetricDataDetails 
    {
        
        /// <value>
        /// The source service or application emitting the metric.
        /// <br/>
        /// A valid namespace value starts with an alphabetical character and includes only alphanumeric characters and underscores. The \"oci_\" prefix is reserved. 
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: my_namespace
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }

        /// <value>
        /// Resource group to assign to the metric. A resource group is a custom string that can be used as a filter. Only one resource group can be applied per metric.
        /// A valid resourceGroup value starts with an alphabetical character and includes only alphanumeric characters, periods (.), underscores (_), hyphens (-), and dollar signs ($).
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: frontend-fleet
        /// </value>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to use for metrics.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The name of the metric.
        /// <br/>
        /// A valid name value starts with an alphabetical character and includes only alphanumeric characters, dots, underscores, hyphens, and dollar signs. The `oci_` prefix is reserved. 
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: my_app.success_rate
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// Qualifiers provided in a metric definition. Available dimensions vary by metric namespace.
        /// Each dimension takes the form of a key-value pair. 
        /// A valid dimension key includes only printable ASCII, excluding periods (.) and spaces. The character limit for a dimension key is 256.
        /// A valid dimension value includes only Unicode characters. The character limit for a dimension value is 256.
        /// Empty strings are not allowed for keys or values. Avoid entering confidential information.
        /// <br/>
        /// Example: &quot;resourceId&quot;: &quot;ocid1.instance.region1.phx.exampleuniqueID&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Dimensions is required.")]
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, string> Dimensions { get; set; }

        /// <value>
        /// Properties describing metrics. These are not part of the unique fields identifying the metric.
        /// Each metadata item takes the form of a key-value pair. The character limit for a metadata key is 256. The character limit for a metadata value is 256.
        /// <br/>
        /// Example: &quot;unit&quot;: &quot;bytes&quot;
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <value>
        /// A list of metric values with timestamps. At least one data point is required per call. 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Datapoints is required.")]
        [JsonProperty(PropertyName = "datapoints")]
        public System.Collections.Generic.List<Datapoint> Datapoints { get; set; }
    }
}

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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// A summary of the SDDC.
    /// </summary>
    public class SddcSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that
        /// contains the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// The availability domain that the SDDC's ESXi hosts are running in.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeAvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "computeAvailabilityDomain")]
        public string ComputeAvailabilityDomain { get; set; }

        /// <value>
        /// A descriptive name for the SDDC. It must be unique, start with a letter, and contain only letters, digits,
        /// whitespaces, dashes and underscores.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// In general, this is a specific version of bundled VMware software supported by
        /// Oracle Cloud VMware Solution (see
        /// {@link #listSupportedVmwareSoftwareVersions(ListSupportedVmwareSoftwareVersionsRequest) listSupportedVmwareSoftwareVersions}).
        /// <br/>
        /// This attribute is not guaranteed to reflect the version of
        /// software currently installed on the ESXi hosts in the SDDC. The purpose
        /// of this attribute is to show the version of software that the Oracle
        /// Cloud VMware Solution will install on any new ESXi hosts that you *add to this
        /// SDDC in the future* with {@link #createEsxiHost(CreateEsxiHostRequest) createEsxiHost}.
        /// <br/>
        /// Therefore, if you upgrade the existing ESXi hosts in the SDDC to use a newer
        /// version of bundled VMware software supported by the Oracle Cloud VMware Solution, you
        /// should use {@link #updateSddc(UpdateSddcRequest) updateSddc} to update the SDDC's
        /// `vmwareSoftwareVersion` with that new version.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VmwareSoftwareVersion is required.")]
        [JsonProperty(PropertyName = "vmwareSoftwareVersion")]
        public string VmwareSoftwareVersion { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment that
        /// contains the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The number of ESXi hosts in the SDDC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EsxiHostsCount is required.")]
        [JsonProperty(PropertyName = "esxiHostsCount")]
        public System.Nullable<int> EsxiHostsCount { get; set; }

        /// <value>
        /// FQDN for vCenter
        /// <br/>
        /// Example: vcenter-my-sddc.sddc.us-phoenix-1.oraclecloud.com
        /// </value>
        [JsonProperty(PropertyName = "vcenterFqdn")]
        public string VcenterFqdn { get; set; }

        /// <value>
        /// FQDN for NSX Manager
        /// <br/>
        /// Example: nsx-my-sddc.sddc.us-phoenix-1.oraclecloud.com
        /// </value>
        [JsonProperty(PropertyName = "nsxManagerFqdn")]
        public string NsxManagerFqdn { get; set; }

        /// <value>
        /// The date and time the SDDC was created, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The date and time the SDDC was updated, in the format defined by
        /// [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }

        /// <value>
        /// The current state of the SDDC.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }

        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}
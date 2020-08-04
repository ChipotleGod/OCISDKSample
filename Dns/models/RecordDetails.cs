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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// A DNS resource record. For more information about records, see [RFC 1034](https://tools.ietf.org/html/rfc1034#section-3.6).
    /// </summary>
    public class RecordDetails 
    {
        
        /// <value>
        /// The fully qualified domain name where the record can be located.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Domain is required.")]
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <value>
        /// A unique identifier for the record within its zone.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recordHash")]
        public string RecordHash { get; set; }

        /// <value>
        /// A Boolean flag indicating whether or not parts of the record
        /// are unable to be explicitly managed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isProtected")]
        public System.Nullable<bool> IsProtected { get; set; }

        /// <value>
        /// The record's data, as whitespace-delimited tokens in
        /// type-specific presentation format. All RDATA is normalized and the
        /// returned presentation of your RDATA may differ from its initial input.
        /// For more information about RDATA, see [Supported DNS Resource Record Types](https://docs.cloud.oracle.com/iaas/Content/DNS/Reference/supporteddnsresource.htm)
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rdata is required.")]
        [JsonProperty(PropertyName = "rdata")]
        public string Rdata { get; set; }

        /// <value>
        /// The latest version of the record's zone in which its RRSet differs
        /// from the preceding version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rrsetVersion")]
        public string RrsetVersion { get; set; }

        /// <value>
        /// The canonical name for the record's type, such as A or CNAME. For more
        /// information, see [Resource Record (RR) TYPEs](https://www.iana.org/assignments/dns-parameters/dns-parameters.xhtml#dns-parameters-4).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Rtype is required.")]
        [JsonProperty(PropertyName = "rtype")]
        public string Rtype { get; set; }

        /// <value>
        /// The Time To Live for the record, in seconds.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ttl is required.")]
        [JsonProperty(PropertyName = "ttl")]
        public System.Nullable<int> Ttl { get; set; }
    }
}
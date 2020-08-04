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
    /// A [TSIG](https://tools.ietf.org/html/rfc2845) key.
    /// </summary>
    public class TSIG 
    {
        
        /// <value>
        /// A domain name identifying the key for a given pair of hosts.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// A base64 string encoding the binary shared secret.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Secret is required.")]
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

        /// <value>
        /// TSIG Algorithms are encoded as domain names, but most consist of only one
        /// non-empty label, which is not required to be explicitly absolute.
        /// Applicable algorithms include: hmac-sha1, hmac-sha224, hmac-sha256,
        /// hmac-sha512. For more information on these algorithms, see [RFC 4635](https://tools.ietf.org/html/rfc4635#section-2).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Algorithm is required.")]
        [JsonProperty(PropertyName = "algorithm")]
        public string Algorithm { get; set; }
    }
}
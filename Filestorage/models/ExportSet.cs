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


namespace Oci.FilestorageService.Models
{
    /// <summary>
    /// A set of file systems to export through one or more mount
    /// targets. Composed of zero or more export resources.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.      
    /// 
    /// </summary>
    public class ExportSet 
    {
        
        /// <value>
        /// The availability domain the export set is in. May be unset
        /// as a blank or NULL value.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }

        /// <value>
        /// The OCID of the compartment that contains the export set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// A user-friendly name. It does not have to be unique, and it is changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My export set
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The OCID of the export set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        ///
        /// <value>
        /// The current state of the export set.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current state of the export set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// Controls the maximum `tbytes`, `fbytes`, and `abytes`,
        /// values reported by `NFS FSSTAT` calls through any associated
        /// mount targets. This is an advanced feature. For most
        /// applications, use the default value. The
        /// `tbytes` value reported by `FSSTAT` will be
        /// `maxFsStatBytes`. The value of `fbytes` and `abytes` will be
        /// `maxFsStatBytes` minus the metered size of the file
        /// system. If the metered size is larger than `maxFsStatBytes`,
        /// then `fbytes` and `abytes` will both be '0'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxFsStatBytes")]
        public System.Nullable<long> MaxFsStatBytes { get; set; }

        /// <value>
        /// Controls the maximum `tfiles`, `ffiles`, and `afiles`
        /// values reported by `NFS FSSTAT` calls through any associated
        /// mount targets. This is an advanced feature. For most
        /// applications, use the default value. The
        /// `tfiles` value reported by `FSSTAT` will be
        /// `maxFsStatFiles`. The value of `ffiles` and `afiles` will be
        /// `maxFsStatFiles` minus the metered size of the file
        /// system. If the metered size is larger than `maxFsStatFiles`,
        /// then `ffiles` and `afiles` will both be '0'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxFsStatFiles")]
        public System.Nullable<long> MaxFsStatFiles { get; set; }

        /// <value>
        /// The date and time the export set was created, expressed
        /// in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) timestamp format.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The OCID of the virtual cloud network (VCN) the export set is in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
    }
}
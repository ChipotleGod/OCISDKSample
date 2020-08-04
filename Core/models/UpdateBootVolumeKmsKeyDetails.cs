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


namespace Oci.CoreService.Models
{
    
    public class UpdateBootVolumeKmsKeyDetails 
    {
        
        /// <value>
        /// The OCID of the new Key Management key to assign to protect the specified volume.
        /// This key has to be a valid Key Management key, and policies must exist to allow the user and the Block Volume service to access this key.
        /// If you specify the same OCID as the previous key's OCID, the Block Volume service will use it to regenerate a volume encryption key.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
    }
}
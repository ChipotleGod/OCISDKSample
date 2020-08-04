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


namespace Oci.BlockchainService.Models
{
    /// <summary>
    /// Scale operation details for a blockchain platform. The scale operation payload has multiple options
    /// - Add one or more Ordering Service Node (addOsns)
    /// - Add one or more Peers (addPeers)
    /// - Add more replicas of CA, Console and Rest Proxy (addReplicas)
    /// - Add more storage to the platform (addStorage)
    /// - Modify the CPU allocation for Peer Nodes (modifyPeers)
    /// - Remove one or more replicas of CA, Console and Rest Proxy (removeReplicas)
    /// - Remove one or more Ordering Service Node (removeOsns)
    /// - Remove one or more Peers (removePeers).
    /// The scale operation payload must have at least one of the above options.
    /// 
    /// </summary>
    public class ScaleBlockchainPlatformDetails 
    {
        
        /// <value>
        /// new OSNs to add
        /// </value>
        [JsonProperty(PropertyName = "addOsns")]
        public System.Collections.Generic.List<CreateOsnDetails> AddOsns { get; set; }

        [JsonProperty(PropertyName = "addReplicas")]
        public ReplicaDetails AddReplicas { get; set; }

        /// <value>
        /// new Peers to add
        /// </value>
        [JsonProperty(PropertyName = "addPeers")]
        public System.Collections.Generic.List<CreatePeerDetails> AddPeers { get; set; }

        [JsonProperty(PropertyName = "addStorage")]
        public ScaleStorageDetails AddStorage { get; set; }

        /// <value>
        /// modify ocpu allocation to existing Peers
        /// </value>
        [JsonProperty(PropertyName = "modifyPeers")]
        public System.Collections.Generic.List<ModifyPeerDetails> ModifyPeers { get; set; }

        [JsonProperty(PropertyName = "removeReplicas")]
        public ReplicaDetails RemoveReplicas { get; set; }

        /// <value>
        /// OSN id list to remove
        /// </value>
        [JsonProperty(PropertyName = "removeOsns")]
        public System.Collections.Generic.List<string> RemoveOsns { get; set; }

        /// <value>
        /// Peer id list to remove
        /// </value>
        [JsonProperty(PropertyName = "removePeers")]
        public System.Collections.Generic.List<string> RemovePeers { get; set; }
    }
}

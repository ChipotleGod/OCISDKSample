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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The attributes of a rule associated with the specified listener, and the name of the rule set that the rule
    /// belongs to.
    /// 
    /// </summary>
    public class ListenerRuleSummary 
    {
        
        /// <value>
        /// A rule object that applies to the listener.
        /// </value>
        [JsonProperty(PropertyName = "rule")]
        public Rule Rule { get; set; }

        /// <value>
        /// The name of the rule set that the rule belongs to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ruleSetName")]
        public string RuleSetName { get; set; }
    }
}

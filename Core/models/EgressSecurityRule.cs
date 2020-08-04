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
    /// <summary>
    /// A rule for allowing outbound IP packets.
    /// </summary>
    public class EgressSecurityRule 
    {
        
        /// <value>
        /// Conceptually, this is the range of IP addresses that a packet originating from the instance
        /// can go to.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * IP address range in CIDR notation. For Example: 192.168.1.0/24 or 2001:0db8:0123:45::/56    Note that IPv6 addressing is currently supported only in certain regions. See    [IPv6 Addresses](https://docs.cloud.oracle.com/Content/Network/Concepts/ipv6.htm).  * The cidrBlock value for a {@link Service}, if you're    setting up a security list rule for traffic destined for a particular Service through    a service gateway. For
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Destination is required.")]
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }
        ///
        /// <value>
        /// Type of destination for the rule. The default is `CIDR_BLOCK`.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `destination` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic destined for a
        ///     particular `Service` through a service gateway).
        /// 
        /// </value>
        ///
        public enum DestinationTypeEnum {
            [EnumMember(Value = "CIDR_BLOCK")]
            CidrBlock,
            [EnumMember(Value = "SERVICE_CIDR_BLOCK")]
            ServiceCidrBlock
        };

        /// <value>
        /// Type of destination for the rule. The default is `CIDR_BLOCK`.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `CIDR_BLOCK`: If the rule's `destination` is an IP address range in CIDR notation.
        /// <br/>
        ///   * `SERVICE_CIDR_BLOCK`: If the rule's `destination` is the `cidrBlock` value for a
        ///     {@link Service} (the rule is for traffic destined for a
        ///     particular `Service` through a service gateway).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "destinationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DestinationTypeEnum> DestinationType { get; set; }

        /// <value>
        /// Optional and valid only for ICMP and ICMPv6. Use to specify a particular ICMP type and code
        /// as defined in:
        /// <br/>
        /// * [ICMP Parameters](http://www.iana.org/assignments/icmp-parameters/icmp-parameters.xhtml)
        /// * [ICMPv6 Parameters](https://www.iana.org/assignments/icmpv6-parameters/icmpv6-parameters.xhtml)
        /// <br/>
        /// If you specify ICMP or ICMPv6 as the protocol but omit this object, then all ICMP types and
        /// codes are allowed. If you do provide this object, the type is required and the code is optional.
        /// To enable MTU negotiation for ingress internet traffic via IPv4, make sure to allow type 3 (\"Destination
        /// Unreachable\") code 4 (\"Fragmentation Needed and Don't Fragment was Set\"). If you need to specify
        /// multiple codes for a single type, create a separate security list rule for each.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "icmpOptions")]
        public IcmpOptions IcmpOptions { get; set; }

        /// <value>
        /// A stateless rule allows traffic in one direction. Remember to add a corresponding
        /// stateless rule in the other direction if you need to support bidirectional traffic. For
        /// example, if egress traffic allows TCP destination port 80, there should be an ingress
        /// rule to allow TCP source port 80. Defaults to false, which means the rule is stateful
        /// and a corresponding rule is not necessary for bidirectional traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isStateless")]
        public System.Nullable<bool> IsStateless { get; set; }

        /// <value>
        /// The transport protocol. Specify either `all` or an IPv4 protocol number as
        /// defined in
        /// [Protocol Numbers](http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml).
        /// Options are supported only for ICMP (\"1\"), TCP (\"6\"), UDP (\"17\"), and ICMPv6 (\"58\").
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <value>
        /// Optional and valid only for TCP. Use to specify particular destination ports for TCP rules.
        /// If you specify TCP as the protocol but omit this object, then all destination ports are allowed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tcpOptions")]
        public TcpOptions TcpOptions { get; set; }

        /// <value>
        /// Optional and valid only for UDP. Use to specify particular destination ports for UDP rules.
        /// If you specify UDP as the protocol but omit this object, then all destination ports are allowed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "udpOptions")]
        public UdpOptions UdpOptions { get; set; }

        /// <value>
        /// An optional description of your choice for the rule.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}

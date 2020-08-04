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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// A list of Web Application Firewall log entries. Each entry is a JSON object, including a timestamp property and other fields varying based on log type. Logs record what rules and countermeasures are triggered by requests and are used as a basis to move request handling into block mode. For more information about WAF logs, see [Logs](https://docs.cloud.oracle.com/iaas/Content/WAF/Tasks/logs.htm).
    /// </summary>
    public class WafLog 
    {
        
        /// <value>
        /// The action taken on the request, either `ALLOW`, `DETECT`, or `BLOCK`.
        /// </value>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <value>
        /// The CAPTCHA action taken on the request, `ALLOW` or `BLOCK`. For more information about
        /// CAPTCHAs, see `UpdateCaptchas`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "captchaAction")]
        public string CaptchaAction { get; set; }

        /// <value>
        /// The CAPTCHA challenge answer that was expected.
        /// </value>
        [JsonProperty(PropertyName = "captchaExpected")]
        public string CaptchaExpected { get; set; }

        /// <value>
        /// The CAPTCHA challenge answer that was received.
        /// </value>
        [JsonProperty(PropertyName = "captchaReceived")]
        public string CaptchaReceived { get; set; }

        /// <value>
        /// The number of times the CAPTCHA challenge was failed.
        /// </value>
        [JsonProperty(PropertyName = "captchaFailCount")]
        public string CaptchaFailCount { get; set; }

        /// <value>
        /// The IPv4 address of the requesting client.
        /// </value>
        [JsonProperty(PropertyName = "clientAddress")]
        public string ClientAddress { get; set; }

        /// <value>
        /// The name of the country where the request originated.
        /// </value>
        [JsonProperty(PropertyName = "countryName")]
        public string CountryName { get; set; }

        /// <value>
        /// The value of the request's `User-Agent` header field.
        /// </value>
        [JsonProperty(PropertyName = "userAgent")]
        public string UserAgent { get; set; }

        /// <value>
        /// The `Host` header data of the request.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <value>
        /// A map of protection rule keys to detection message details. Detections are
        /// requests that matched the criteria of a protection rule but the rule's
        /// action was set to `DETECT`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "protectionRuleDetections")]
        public System.Collections.Generic.Dictionary<string, string> ProtectionRuleDetections { get; set; }

        /// <value>
        /// The HTTP method of the request.
        /// </value>
        [JsonProperty(PropertyName = "httpMethod")]
        public string HttpMethod { get; set; }

        /// <value>
        /// The path and query string of the request.
        /// </value>
        [JsonProperty(PropertyName = "requestUrl")]
        public string RequestUrl { get; set; }

        /// <value>
        /// The map of the request's header names to their respective values.
        /// </value>
        [JsonProperty(PropertyName = "httpHeaders")]
        public System.Collections.Generic.Dictionary<string, string> HttpHeaders { get; set; }

        /// <value>
        /// The `Referrer` header value of the request.
        /// </value>
        [JsonProperty(PropertyName = "referrer")]
        public string Referrer { get; set; }

        /// <value>
        /// The status code of the response.
        /// </value>
        [JsonProperty(PropertyName = "responseCode")]
        public System.Nullable<int> ResponseCode { get; set; }

        /// <value>
        /// The size in bytes of the response.
        /// </value>
        [JsonProperty(PropertyName = "responseSize")]
        public System.Nullable<int> ResponseSize { get; set; }

        /// <value>
        /// The incident key of a request. An incident key is generated for
        /// each request processed by the Web Application Firewall and is used to
        /// idenitfy blocked requests in applicable logs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "incidentKey")]
        public string IncidentKey { get; set; }

        /// <value>
        /// The hashed signature of the device's fingerprint. For more information,
        /// see `DeviceFingerPrintChallenge`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fingerprint")]
        public string Fingerprint { get; set; }

        /// <value>
        /// The type of device that the request was made from.
        /// </value>
        [JsonProperty(PropertyName = "device")]
        public string Device { get; set; }

        /// <value>
        /// ISO 3166-1 alpha-2 code of the country from which the request originated.
        /// For a list of codes, see [ISO's website](https://www.iso.org/obp/ui/#search/code/).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <value>
        /// A map of header names to values of the request sent to the origin, including any headers
        /// appended by the Web Application Firewall.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "requestHeaders")]
        public System.Collections.Generic.Dictionary<string, string> RequestHeaders { get; set; }

        /// <value>
        /// The `ThreatFeed` key that matched the request. For more information about
        /// threat feeds, see `UpdateThreatFeeds`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "threatFeedKey")]
        public string ThreatFeedKey { get; set; }

        /// <value>
        /// The `AccessRule` key that matched the request. For more information about
        /// access rules, see `UpdateAccessRules`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "accessRuleKey")]
        public string AccessRuleKey { get; set; }

        /// <value>
        /// The `AddressRateLimiting` key that matched the request. For more information
        /// about address rate limiting, see `UpdateWafAddressRateLimiting`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "addressRateLimitingKey")]
        public string AddressRateLimitingKey { get; set; }

        /// <value>
        /// The date and time the Web Application Firewall processed the request and logged it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }

        /// <value>
        /// The type of log of the request. For more about log types, see [Logs](https://docs.cloud.oracle.com/iaas/Content/WAF/Tasks/logs.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logType")]
        public string LogType { get; set; }

        /// <value>
        /// The address of the origin server where the request was sent.
        /// </value>
        [JsonProperty(PropertyName = "originAddress")]
        public string OriginAddress { get; set; }

        /// <value>
        /// The amount of time it took the origin server to respond to the request, in seconds.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "originResponseTime")]
        public string OriginResponseTime { get; set; }
    }
}

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
    /// The challenge settings if `action` is set to `BLOCK`.
    /// </summary>
    public class BlockChallengeSettings 
    {
                ///
        /// <value>
        /// The method used to block requests that fail the challenge, if `action` is set to `BLOCK`. If unspecified, defaults to `SHOW_ERROR_PAGE`.
        /// </value>
        ///
        public enum BlockActionEnum {
            [EnumMember(Value = "SET_RESPONSE_CODE")]
            SetResponseCode,
            [EnumMember(Value = "SHOW_ERROR_PAGE")]
            ShowErrorPage,
            [EnumMember(Value = "SHOW_CAPTCHA")]
            ShowCaptcha
        };

        /// <value>
        /// The method used to block requests that fail the challenge, if `action` is set to `BLOCK`. If unspecified, defaults to `SHOW_ERROR_PAGE`.
        /// </value>
        [JsonProperty(PropertyName = "blockAction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BlockActionEnum> BlockAction { get; set; }

        /// <value>
        /// The response status code to return when `action` is set to `BLOCK`, `blockAction` is set to `SET_RESPONSE_CODE` or `SHOW_ERROR_PAGE`, and the request is blocked. If unspecified, defaults to `403`. The list of available response codes: `200`, `201`, `202`, `204`, `206`, `300`, `301`, `302`, `303`, `304`, `307`, `400`, `401`, `403`, `404`, `405`, `408`, `409`, `411`, `412`, `413`, `414`, `415`, `416`, `422`, `444`, `499`, `500`, `501`, `502`, `503`, `504`, `507`.
        /// </value>
        [JsonProperty(PropertyName = "blockResponseCode")]
        public System.Nullable<int> BlockResponseCode { get; set; }

        /// <value>
        /// The message to show on the error page when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_ERROR_PAGE`, and the request is blocked. If unspecified, defaults to `Access to the website is blocked`.
        /// </value>
        [JsonProperty(PropertyName = "blockErrorPageMessage")]
        public string BlockErrorPageMessage { get; set; }

        /// <value>
        /// The description text to show on the error page when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_ERROR_PAGE`, and the request is blocked. If unspecified, defaults to `Access blocked by website owner. Please contact support.`
        /// </value>
        [JsonProperty(PropertyName = "blockErrorPageDescription")]
        public string BlockErrorPageDescription { get; set; }

        /// <value>
        /// The error code to show on the error page when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_ERROR_PAGE` and the request is blocked. If unspecified, defaults to `403`.
        /// </value>
        [JsonProperty(PropertyName = "blockErrorPageCode")]
        public string BlockErrorPageCode { get; set; }

        /// <value>
        /// The title used when showing a CAPTCHA challenge when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_CAPTCHA`, and the request is blocked. If unspecified, defaults to `Are you human?`
        /// </value>
        [JsonProperty(PropertyName = "captchaTitle")]
        public string CaptchaTitle { get; set; }

        /// <value>
        /// The text to show in the header when showing a CAPTCHA challenge when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_CAPTCHA`, and the request is blocked. If unspecified, defaults to `We have detected an increased number of attempts to access this webapp. To help us keep this webapp secure, please let us know that you are not a robot by entering the text from captcha below.`
        /// </value>
        [JsonProperty(PropertyName = "captchaHeader")]
        public string CaptchaHeader { get; set; }

        /// <value>
        /// The text to show in the footer when showing a CAPTCHA challenge when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_CAPTCHA`, and the request is blocked. If unspecified, default to `Enter the letters and numbers as they are shown in image above`.
        /// </value>
        [JsonProperty(PropertyName = "captchaFooter")]
        public string CaptchaFooter { get; set; }

        /// <value>
        /// The text to show on the label of the CAPTCHA challenge submit button when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_CAPTCHA`, and the request is blocked. If unspecified, defaults to `Yes, I am human`.
        /// </value>
        [JsonProperty(PropertyName = "captchaSubmitLabel")]
        public string CaptchaSubmitLabel { get; set; }
    }
}

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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// The details for creating a configuration source provider of the type `GITLAB_ACCESS_TOKEN`.
    /// This type corresponds to a configuration source provider in GitLab that is authenticated with a personal access token.
    /// 
    /// </summary>
    public class CreateGitlabAccessTokenConfigurationSourceProviderDetails : CreateConfigurationSourceProviderDetails
    {
        
        /// <value>
        /// The Git service API endpoint.
        /// Example: https://gitlab.com/api/v4/
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApiEndpoint is required.")]
        [JsonProperty(PropertyName = "apiEndpoint")]
        public string ApiEndpoint { get; set; }

        /// <value>
        /// The personal access token to be configured on the Git repository. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccessToken is required.")]
        [JsonProperty(PropertyName = "accessToken")]
        public string AccessToken { get; set; }
    }
}
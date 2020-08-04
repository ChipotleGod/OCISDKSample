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
using Newtonsoft.Json.Linq;

namespace Oci.CoreService.Models
{
    /// <summary>
    /// Volume attachmentDetails. Please see {@link AttachVolumeDetails}
    /// 
    /// </summary>
    [JsonConverter(typeof(InstanceConfigurationAttachVolumeDetailsModelConverter))]
    public class InstanceConfigurationAttachVolumeDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it cannot be changed. Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Whether the attachment should be created in read-only mode.
        /// </value>
        [JsonProperty(PropertyName = "isReadOnly")]
        public System.Nullable<bool> IsReadOnly { get; set; }

        /// <value>
        /// The device name.
        /// </value>
        [JsonProperty(PropertyName = "device")]
        public string Device { get; set; }

        /// <value>
        /// Whether the attachment should be created in shareable mode. If an attachment
        /// is created in shareable mode, then other instances can attach the same volume, provided
        /// that they also create their attachments in shareable mode. Only certain volume types can
        /// be attached in shareable mode. Defaults to false if not specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isShareable")]
        public System.Nullable<bool> IsShareable { get; set; }

        /// <value>
        /// The type of volume. The only supported values are \"iscsi\" and \"paravirtualized\".
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class InstanceConfigurationAttachVolumeDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(InstanceConfigurationAttachVolumeDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(InstanceConfigurationAttachVolumeDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "iscsi":
                    obj = new InstanceConfigurationIscsiAttachVolumeDetails();
                    break;
                case "paravirtualized":
                    obj = new InstanceConfigurationParavirtualizedAttachVolumeDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}

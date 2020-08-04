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

namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The abstract read attribute.
    /// </summary>
    [JsonConverter(typeof(AbstractReadAttributeModelConverter))]
    public class AbstractReadAttribute 
    {
                ///
        /// <value>
        /// The type of the abstract read attribute.
        /// </value>
        ///
        public enum ModelTypeEnum {
            [EnumMember(Value = "ORACLEREADATTRIBUTE")]
            Oraclereadattribute
        };

        /// <value>
        /// The type of the abstract read attribute.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelType is required.")]
        [JsonProperty(PropertyName = "modelType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ModelTypeEnum> ModelType { get; set; }
    }

    public class AbstractReadAttributeModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AbstractReadAttribute);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AbstractReadAttribute);
            var discriminator = jsonObject["modelType"].Value<string>();
            switch (discriminator)
            {
                case "ORACLEREADATTRIBUTE":
                    obj = new OracleReadAttribute();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}

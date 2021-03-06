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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about TaskRun.
    /// </summary>
    public class TaskRunSummary 
    {
        
        /// <value>
        /// The key of the object.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <value>
        /// The type of the object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        public string ModelType { get; set; }

        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }

        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }

        /// <value>
        /// Free form text without any restriction on permitted characters. Name can have letters, numbers, and special characters. The value can be edited by the user and it is restricted to 1000 characters
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// Detailed description for the object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
        ///
        /// <value>
        /// status
        /// </value>
        ///
        public enum StatusEnum {
            [EnumMember(Value = "NOT_STARTED")]
            NotStarted,
            [EnumMember(Value = "QUEUED")]
            Queued,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// status
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }

        /// <value>
        /// startTimeMillis
        /// </value>
        [JsonProperty(PropertyName = "startTimeMillis")]
        public System.Nullable<long> StartTimeMillis { get; set; }

        /// <value>
        /// endTimeMillis
        /// </value>
        [JsonProperty(PropertyName = "endTimeMillis")]
        public System.Nullable<long> EndTimeMillis { get; set; }

        /// <value>
        /// lastUpdated
        /// </value>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.Nullable<long> LastUpdated { get; set; }

        /// <value>
        /// Number of records processed in task run.
        /// </value>
        [JsonProperty(PropertyName = "recordsWritten")]
        public System.Nullable<long> RecordsWritten { get; set; }

        /// <value>
        /// Number of bytes processed in task run.
        /// </value>
        [JsonProperty(PropertyName = "bytesProcessed")]
        public System.Nullable<long> BytesProcessed { get; set; }

        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        ///
        /// <value>
        /// The type of the task for the run.
        /// </value>
        ///
        public enum TaskTypeEnum {
            [EnumMember(Value = "INTEGRATION_TASK")]
            IntegrationTask,
            [EnumMember(Value = "DATA_LOADER_TASK")]
            DataLoaderTask
        };

        /// <value>
        /// The type of the task for the run.
        /// </value>
        [JsonProperty(PropertyName = "taskType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TaskTypeEnum> TaskType { get; set; }

        /// <value>
        /// Value can only contain upper case letters, underscore and numbers. It should begin with upper case letter or underscore. The value can be edited by the user.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public ObjectMetadata Metadata { get; set; }
    }
}

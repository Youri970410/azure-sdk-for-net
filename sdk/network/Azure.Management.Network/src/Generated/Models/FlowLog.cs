// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> A flow log resource. </summary>
    public partial class FlowLog : Resource
    {
        /// <summary> Initializes a new instance of FlowLog. </summary>
        public FlowLog()
        {
        }

        /// <summary> Initializes a new instance of FlowLog. </summary>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="targetResourceId"> ID of network security group to which flow log will be applied. </param>
        /// <param name="targetResourceGuid"> Guid of network security group to which flow log will be applied. </param>
        /// <param name="storageId"> ID of the storage account which is used to store the flow log. </param>
        /// <param name="enabled"> Flag to enable/disable flow logging. </param>
        /// <param name="retentionPolicy"> Parameters that define the retention policy for flow log. </param>
        /// <param name="format"> Parameters that define the flow log format. </param>
        /// <param name="flowAnalyticsConfiguration"> Parameters that define the configuration of traffic analytics. </param>
        /// <param name="provisioningState"> The provisioning state of the flow log. </param>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal FlowLog(string etag, string targetResourceId, string targetResourceGuid, string storageId, bool? enabled, RetentionPolicyParameters retentionPolicy, FlowLogFormatParameters format, TrafficAnalyticsProperties flowAnalyticsConfiguration, ProvisioningState? provisioningState, string id, string name, string type, string location, IDictionary<string, string> tags) : base(id, name, type, location, tags)
        {
            Etag = etag;
            TargetResourceId = targetResourceId;
            TargetResourceGuid = targetResourceGuid;
            StorageId = storageId;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            Format = format;
            FlowAnalyticsConfiguration = flowAnalyticsConfiguration;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> ID of network security group to which flow log will be applied. </summary>
        public string TargetResourceId { get; set; }
        /// <summary> Guid of network security group to which flow log will be applied. </summary>
        public string TargetResourceGuid { get; }
        /// <summary> ID of the storage account which is used to store the flow log. </summary>
        public string StorageId { get; set; }
        /// <summary> Flag to enable/disable flow logging. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Parameters that define the retention policy for flow log. </summary>
        public RetentionPolicyParameters RetentionPolicy { get; set; }
        /// <summary> Parameters that define the flow log format. </summary>
        public FlowLogFormatParameters Format { get; set; }
        /// <summary> Parameters that define the configuration of traffic analytics. </summary>
        public TrafficAnalyticsProperties FlowAnalyticsConfiguration { get; set; }
        /// <summary> The provisioning state of the flow log. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VirtualApplianceSite data model. </summary>
    public partial class VirtualApplianceSiteData : WritableSubResource
    {
        /// <summary> Initializes a new instance of VirtualApplianceSiteData. </summary>
        public VirtualApplianceSiteData()
        {
        }

        /// <summary> Initializes a new instance of VirtualApplianceSiteData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Name of the virtual appliance site. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Site type. </param>
        /// <param name="addressPrefix"> Address Prefix. </param>
        /// <param name="o365Policy"> Office 365 Policy. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        internal VirtualApplianceSiteData(string id, string name, string etag, string type, string addressPrefix, Office365PolicyProperties o365Policy, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            AddressPrefix = addressPrefix;
            O365Policy = o365Policy;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the virtual appliance site. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Site type. </summary>
        public string Type { get; }
        /// <summary> Address Prefix. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> Office 365 Policy. </summary>
        public Office365PolicyProperties O365Policy { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}

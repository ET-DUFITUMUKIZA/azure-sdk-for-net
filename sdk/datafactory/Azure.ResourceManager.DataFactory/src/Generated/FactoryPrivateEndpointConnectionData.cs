// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class representing the FactoryPrivateEndpointConnection data model. </summary>
    public partial class FactoryPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of FactoryPrivateEndpointConnectionData. </summary>
        public FactoryPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of FactoryPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Core resource properties. </param>
        /// <param name="eTag"> Etag identifies change in the resource. </param>
        internal FactoryPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, FactoryPrivateEndpointProperties properties, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = eTag;
        }

        /// <summary> Core resource properties. </summary>
        public FactoryPrivateEndpointProperties Properties { get; set; }
        /// <summary> Etag identifies change in the resource. </summary>
        public ETag? ETag { get; }
    }
}

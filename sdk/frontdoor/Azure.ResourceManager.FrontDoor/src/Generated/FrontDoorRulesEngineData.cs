// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary> A class representing the FrontDoorRulesEngine data model. </summary>
    public partial class FrontDoorRulesEngineData : ResourceData
    {
        /// <summary> Initializes a new instance of FrontDoorRulesEngineData. </summary>
        public FrontDoorRulesEngineData()
        {
            Rules = new ChangeTrackingList<RulesEngineRule>();
        }

        /// <summary> Initializes a new instance of FrontDoorRulesEngineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="rules"> A list of rules that define a particular Rules Engine Configuration. </param>
        /// <param name="resourceState"> Resource status. </param>
        internal FrontDoorRulesEngineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<RulesEngineRule> rules, FrontDoorResourceState? resourceState) : base(id, name, resourceType, systemData)
        {
            Rules = rules;
            ResourceState = resourceState;
        }

        /// <summary> A list of rules that define a particular Rules Engine Configuration. </summary>
        public IList<RulesEngineRule> Rules { get; }
        /// <summary> Resource status. </summary>
        public FrontDoorResourceState? ResourceState { get; }
    }
}

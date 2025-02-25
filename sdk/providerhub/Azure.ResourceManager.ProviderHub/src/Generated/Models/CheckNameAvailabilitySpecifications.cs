// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CheckNameAvailabilitySpecifications. </summary>
    public partial class CheckNameAvailabilitySpecifications
    {
        /// <summary> Initializes a new instance of CheckNameAvailabilitySpecifications. </summary>
        public CheckNameAvailabilitySpecifications()
        {
            ResourceTypesWithCustomValidation = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CheckNameAvailabilitySpecifications. </summary>
        /// <param name="enableDefaultValidation"></param>
        /// <param name="resourceTypesWithCustomValidation"></param>
        internal CheckNameAvailabilitySpecifications(bool? enableDefaultValidation, IList<string> resourceTypesWithCustomValidation)
        {
            EnableDefaultValidation = enableDefaultValidation;
            ResourceTypesWithCustomValidation = resourceTypesWithCustomValidation;
        }

        /// <summary> Gets or sets the enable default validation. </summary>
        public bool? EnableDefaultValidation { get; set; }
        /// <summary> Gets the resource types with custom validation. </summary>
        public IList<string> ResourceTypesWithCustomValidation { get; }
    }
}

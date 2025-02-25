// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The CSPM P1 for GCP offering. </summary>
    public partial class DefenderCspmGcpOffering : CloudOffering
    {
        /// <summary> Initializes a new instance of DefenderCspmGcpOffering. </summary>
        public DefenderCspmGcpOffering()
        {
            OfferingType = OfferingType.DefenderCspmGcp;
        }

        /// <summary> Initializes a new instance of DefenderCspmGcpOffering. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        internal DefenderCspmGcpOffering(OfferingType offeringType, string description) : base(offeringType, description)
        {
            OfferingType = offeringType;
        }
    }
}

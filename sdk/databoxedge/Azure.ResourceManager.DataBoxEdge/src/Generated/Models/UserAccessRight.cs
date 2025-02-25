// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The mapping between a particular user and the access type on the SMB share. </summary>
    public partial class UserAccessRight
    {
        /// <summary> Initializes a new instance of UserAccessRight. </summary>
        /// <param name="userId"> User ID (already existing in the device). </param>
        /// <param name="accessType"> Type of access to be allowed for the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        public UserAccessRight(ResourceIdentifier userId, ShareAccessType accessType)
        {
            if (userId == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            UserId = userId;
            AccessType = accessType;
        }

        /// <summary> User ID (already existing in the device). </summary>
        public ResourceIdentifier UserId { get; set; }
        /// <summary> Type of access to be allowed for the user. </summary>
        public ShareAccessType AccessType { get; set; }
    }
}

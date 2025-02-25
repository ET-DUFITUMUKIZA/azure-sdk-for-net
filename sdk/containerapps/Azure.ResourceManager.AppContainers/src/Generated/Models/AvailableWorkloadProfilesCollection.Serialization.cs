// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class AvailableWorkloadProfilesCollection
    {
        internal static AvailableWorkloadProfilesCollection DeserializeAvailableWorkloadProfilesCollection(JsonElement element)
        {
            IReadOnlyList<AvailableWorkloadProfile> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<AvailableWorkloadProfile> array = new List<AvailableWorkloadProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableWorkloadProfile.DeserializeAvailableWorkloadProfile(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AvailableWorkloadProfilesCollection(value, nextLink.Value);
        }
    }
}

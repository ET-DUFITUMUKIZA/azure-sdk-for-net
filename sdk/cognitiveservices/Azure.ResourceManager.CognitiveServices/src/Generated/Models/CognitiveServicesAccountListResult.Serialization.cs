// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class CognitiveServicesAccountListResult
    {
        internal static CognitiveServicesAccountListResult DeserializeCognitiveServicesAccountListResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<CognitiveServicesAccountData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CognitiveServicesAccountData> array = new List<CognitiveServicesAccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesAccountData.DeserializeCognitiveServicesAccountData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CognitiveServicesAccountListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NamedPartitionScheme : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("names");
            writer.WriteStartArray();
            foreach (var item in Names)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("partitionScheme");
            writer.WriteStringValue(PartitionScheme.ToString());
            writer.WriteEndObject();
        }

        internal static NamedPartitionScheme DeserializeNamedPartitionScheme(JsonElement element)
        {
            IList<string> names = default;
            PartitionScheme partitionScheme = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("names"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    names = array;
                    continue;
                }
                if (property.NameEquals("partitionScheme"))
                {
                    partitionScheme = new PartitionScheme(property.Value.GetString());
                    continue;
                }
            }
            return new NamedPartitionScheme(partitionScheme, names);
        }
    }
}

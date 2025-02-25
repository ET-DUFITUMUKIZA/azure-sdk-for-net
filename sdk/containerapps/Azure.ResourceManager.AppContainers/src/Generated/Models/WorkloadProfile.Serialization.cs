// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class WorkloadProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("workloadProfileType");
            writer.WriteStringValue(WorkloadProfileType);
            writer.WritePropertyName("minimumCount");
            writer.WriteNumberValue(MinimumCount);
            writer.WritePropertyName("maximumCount");
            writer.WriteNumberValue(MaximumCount);
            writer.WriteEndObject();
        }

        internal static WorkloadProfile DeserializeWorkloadProfile(JsonElement element)
        {
            string workloadProfileType = default;
            int minimumCount = default;
            int maximumCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workloadProfileType"))
                {
                    workloadProfileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumCount"))
                {
                    minimumCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumCount"))
                {
                    maximumCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new WorkloadProfile(workloadProfileType, minimumCount, maximumCount);
        }
    }
}

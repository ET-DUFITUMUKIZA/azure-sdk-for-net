// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class DynamicClassificationTaskParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClassificationType))
            {
                writer.WritePropertyName("classificationType");
                writer.WriteStringValue(ClassificationType.Value.ToString());
            }
            writer.WritePropertyName("categories");
            writer.WriteStartArray();
            foreach (var item in Categories)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("modelVersion");
                writer.WriteStringValue(ModelVersion);
            }
            if (Optional.IsDefined(LoggingOptOut))
            {
                writer.WritePropertyName("loggingOptOut");
                writer.WriteBooleanValue(LoggingOptOut.Value);
            }
            writer.WriteEndObject();
        }

        internal static DynamicClassificationTaskParameters DeserializeDynamicClassificationTaskParameters(JsonElement element)
        {
            Optional<ClassificationType> classificationType = default;
            IList<string> categories = default;
            Optional<string> modelVersion = default;
            Optional<bool> loggingOptOut = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classificationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    classificationType = new ClassificationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("categories"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    categories = array;
                    continue;
                }
                if (property.NameEquals("modelVersion"))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingOptOut"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loggingOptOut = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DynamicClassificationTaskParameters(Optional.ToNullable(loggingOptOut), modelVersion.Value, Optional.ToNullable(classificationType), categories);
        }
    }
}

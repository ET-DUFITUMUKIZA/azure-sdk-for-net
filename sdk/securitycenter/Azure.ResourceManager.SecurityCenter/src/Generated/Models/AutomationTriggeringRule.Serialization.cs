// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AutomationTriggeringRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PropertyJPath))
            {
                writer.WritePropertyName("propertyJPath");
                writer.WriteStringValue(PropertyJPath);
            }
            if (Optional.IsDefined(PropertyType))
            {
                writer.WritePropertyName("propertyType");
                writer.WriteStringValue(PropertyType.Value.ToString());
            }
            if (Optional.IsDefined(ExpectedValue))
            {
                writer.WritePropertyName("expectedValue");
                writer.WriteStringValue(ExpectedValue);
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator");
                writer.WriteStringValue(Operator.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AutomationTriggeringRule DeserializeAutomationTriggeringRule(JsonElement element)
        {
            Optional<string> propertyJPath = default;
            Optional<AutomationTriggeringRulePropertyType> propertyType = default;
            Optional<string> expectedValue = default;
            Optional<AutomationTriggeringRuleOperator> @operator = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("propertyJPath"))
                {
                    propertyJPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    propertyType = new AutomationTriggeringRulePropertyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expectedValue"))
                {
                    expectedValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @operator = new AutomationTriggeringRuleOperator(property.Value.GetString());
                    continue;
                }
            }
            return new AutomationTriggeringRule(propertyJPath.Value, Optional.ToNullable(propertyType), expectedValue.Value, Optional.ToNullable(@operator));
        }
    }
}

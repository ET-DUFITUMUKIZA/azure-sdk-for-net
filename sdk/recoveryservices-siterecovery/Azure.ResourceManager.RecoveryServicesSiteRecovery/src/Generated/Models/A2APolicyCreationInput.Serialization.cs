// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2APolicyCreationInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointHistory))
            {
                writer.WritePropertyName("recoveryPointHistory");
                writer.WriteNumberValue(RecoveryPointHistory.Value);
            }
            if (Optional.IsDefined(CrashConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("crashConsistentFrequencyInMinutes");
                writer.WriteNumberValue(CrashConsistentFrequencyInMinutes.Value);
            }
            if (Optional.IsDefined(AppConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("appConsistentFrequencyInMinutes");
                writer.WriteNumberValue(AppConsistentFrequencyInMinutes.Value);
            }
            writer.WritePropertyName("multiVmSyncStatus");
            writer.WriteStringValue(MultiVmSyncStatus.ToString());
            writer.WritePropertyName("instanceType");
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}

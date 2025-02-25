// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class GitRepositoryDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url");
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds");
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds");
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(RepositoryRef))
            {
                if (RepositoryRef != null)
                {
                    writer.WritePropertyName("repositoryRef");
                    writer.WriteObjectValue(RepositoryRef);
                }
                else
                {
                    writer.WriteNull("repositoryRef");
                }
            }
            if (Optional.IsDefined(SshKnownHosts))
            {
                if (SshKnownHosts != null)
                {
                    writer.WritePropertyName("sshKnownHosts");
                    writer.WriteStringValue(SshKnownHosts);
                }
                else
                {
                    writer.WriteNull("sshKnownHosts");
                }
            }
            if (Optional.IsDefined(HttpsUser))
            {
                if (HttpsUser != null)
                {
                    writer.WritePropertyName("httpsUser");
                    writer.WriteStringValue(HttpsUser);
                }
                else
                {
                    writer.WriteNull("httpsUser");
                }
            }
            if (Optional.IsDefined(HttpsCACert))
            {
                if (HttpsCACert != null)
                {
                    writer.WritePropertyName("httpsCACert");
                    writer.WriteStringValue(HttpsCACert);
                }
                else
                {
                    writer.WriteNull("httpsCACert");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef");
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
                }
            }
            writer.WriteEndObject();
        }

        internal static GitRepositoryDefinition DeserializeGitRepositoryDefinition(JsonElement element)
        {
            Optional<Uri> url = default;
            Optional<long?> timeoutInSeconds = default;
            Optional<long?> syncIntervalInSeconds = default;
            Optional<RepositoryRefDefinition> repositoryRef = default;
            Optional<string> sshKnownHosts = default;
            Optional<string> httpsUser = default;
            Optional<string> httpsCACert = default;
            Optional<string> localAuthRef = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("repositoryRef"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        repositoryRef = null;
                        continue;
                    }
                    repositoryRef = RepositoryRefDefinition.DeserializeRepositoryRefDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("sshKnownHosts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sshKnownHosts = null;
                        continue;
                    }
                    sshKnownHosts = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsUser"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpsUser = null;
                        continue;
                    }
                    httpsUser = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsCACert"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpsCACert = null;
                        continue;
                    }
                    httpsCACert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localAuthRef"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        localAuthRef = null;
                        continue;
                    }
                    localAuthRef = property.Value.GetString();
                    continue;
                }
            }
            return new GitRepositoryDefinition(url.Value, Optional.ToNullable(timeoutInSeconds), Optional.ToNullable(syncIntervalInSeconds), repositoryRef.Value, sshKnownHosts.Value, httpsUser.Value, httpsCACert.Value, localAuthRef.Value);
        }
    }
}

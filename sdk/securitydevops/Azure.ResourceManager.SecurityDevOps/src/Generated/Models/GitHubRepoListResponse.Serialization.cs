// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityDevOps;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    internal partial class GitHubRepoListResponse
    {
        internal static GitHubRepoListResponse DeserializeGitHubRepoListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<GitHubRepoData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GitHubRepoData> array = new List<GitHubRepoData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GitHubRepoData.DeserializeGitHubRepoData(item));
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
            return new GitHubRepoListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}

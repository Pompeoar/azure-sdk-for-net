// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveNetworkSecurityGroupListResult
    {
        internal static EffectiveNetworkSecurityGroupListResult DeserializeEffectiveNetworkSecurityGroupListResult(JsonElement element)
        {
            IReadOnlyList<EffectiveNetworkSecurityGroup> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EffectiveNetworkSecurityGroup> array = new List<EffectiveNetworkSecurityGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(EffectiveNetworkSecurityGroup.DeserializeEffectiveNetworkSecurityGroup(item));
                        }
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EffectiveNetworkSecurityGroupListResult(value, nextLink);
        }
    }
}
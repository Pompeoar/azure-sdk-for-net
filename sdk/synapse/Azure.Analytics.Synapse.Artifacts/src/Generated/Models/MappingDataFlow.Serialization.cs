// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class MappingDataFlow : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Annotations != null)
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Folder != null)
            {
                writer.WritePropertyName("folder");
                writer.WriteObjectValue(Folder);
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Sources != null)
            {
                writer.WritePropertyName("sources");
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Sinks != null)
            {
                writer.WritePropertyName("sinks");
                writer.WriteStartArray();
                foreach (var item in Sinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Transformations != null)
            {
                writer.WritePropertyName("transformations");
                writer.WriteStartArray();
                foreach (var item in Transformations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Script != null)
            {
                writer.WritePropertyName("script");
                writer.WriteStringValue(Script);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MappingDataFlow DeserializeMappingDataFlow(JsonElement element)
        {
            string type = default;
            string description = default;
            IList<object> annotations = default;
            DataFlowFolder folder = default;
            IList<DataFlowSource> sources = default;
            IList<DataFlowSink> sinks = default;
            IList<Transformation> transformations = default;
            string script = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("folder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folder = DataFlowFolder.DeserializeDataFlowFolder(property.Value);
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sources"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFlowSource> array = new List<DataFlowSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(DataFlowSource.DeserializeDataFlowSource(item));
                                }
                            }
                            sources = array;
                            continue;
                        }
                        if (property0.NameEquals("sinks"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataFlowSink> array = new List<DataFlowSink>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(DataFlowSink.DeserializeDataFlowSink(item));
                                }
                            }
                            sinks = array;
                            continue;
                        }
                        if (property0.NameEquals("transformations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Transformation> array = new List<Transformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(Transformation.DeserializeTransformation(item));
                                }
                            }
                            transformations = array;
                            continue;
                        }
                        if (property0.NameEquals("script"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            script = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MappingDataFlow(type, description, annotations, folder, sources, sinks, transformations, script);
        }
    }
}
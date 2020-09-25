// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    public partial class CustomFormModelInfo
    {
        internal static CustomFormModelInfo DeserializeCustomFormModelInfo(JsonElement element)
        {
            string modelId = default;
            CustomFormModelStatus status = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            Optional<string> modelName = default;
            Optional<Attributes> attributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToCustomFormModelStatus();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modelName"))
                {
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"))
                {
                    attributes = Training.Attributes.DeserializeAttributes(property.Value);
                    continue;
                }
            }
            return new CustomFormModelInfo(modelId, status, createdDateTime, lastUpdatedDateTime, modelName.Value, attributes.Value);
        }
    }
}

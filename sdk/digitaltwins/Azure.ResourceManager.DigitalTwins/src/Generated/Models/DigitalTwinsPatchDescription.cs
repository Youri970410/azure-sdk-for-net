// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The description of the DigitalTwins service. </summary>
    internal partial class DigitalTwinsPatchDescription
    {
        /// <summary> Initializes a new instance of DigitalTwinsPatchDescription. </summary>
        public DigitalTwinsPatchDescription()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Instance tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}

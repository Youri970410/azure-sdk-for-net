// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Virtual Machine operation response. </summary>
    public partial class VirtualMachineScaleSetListWithLinkResult
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetListWithLinkResult. </summary>
        /// <param name="value"> The list of virtual machine scale sets. </param>
        internal VirtualMachineScaleSetListWithLinkResult(IEnumerable<VirtualMachineScaleSet> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetListWithLinkResult. </summary>
        /// <param name="value"> The list of virtual machine scale sets. </param>
        /// <param name="nextLink"> The uri to fetch the next page of Virtual Machine Scale Sets. Call ListNext() with this to fetch the next page of Virtual Machine Scale Sets. </param>
        internal VirtualMachineScaleSetListWithLinkResult(IReadOnlyList<VirtualMachineScaleSet> value, string nextLink)
        {
            Value = value ?? new List<VirtualMachineScaleSet>();
            NextLink = nextLink;
        }

        /// <summary> The list of virtual machine scale sets. </summary>
        public IReadOnlyList<VirtualMachineScaleSet> Value { get; }
        /// <summary> The uri to fetch the next page of Virtual Machine Scale Sets. Call ListNext() with this to fetch the next page of Virtual Machine Scale Sets. </summary>
        public string NextLink { get; }
    }
}

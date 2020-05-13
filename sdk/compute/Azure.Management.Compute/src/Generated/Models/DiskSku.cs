// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Compute.Models
{
    /// <summary> The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, or UltraSSD_LRS. </summary>
    public partial class DiskSku
    {
        /// <summary> Initializes a new instance of DiskSku. </summary>
        public DiskSku()
        {
        }

        /// <summary> Initializes a new instance of DiskSku. </summary>
        /// <param name="name"> The sku name. </param>
        /// <param name="tier"> The sku tier. </param>
        internal DiskSku(DiskStorageAccountTypes? name, string tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> The sku name. </summary>
        public DiskStorageAccountTypes? Name { get; set; }
        /// <summary> The sku tier. </summary>
        public string Tier { get; }
    }
}

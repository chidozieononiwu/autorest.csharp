// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> Virtual machine image resource information. </summary>
    public partial class VirtualMachineImageResource : WritableSubResource
    {
        /// <summary> Initializes a new instance of VirtualMachineImageResource. </summary>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="location"> The supported Azure location of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="location"/> is null. </exception>
        public VirtualMachineImageResource(string name, string location)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Name = name;
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineImageResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="location"> The supported Azure location of the resource. </param>
        /// <param name="tags"> Specifies the tags that are assigned to the virtual machine. For more information about using tags, see [Using tags to organize your Azure resources](https://docs.microsoft.com/azure/azure-resource-manager/resource-group-using-tags.md). </param>
        internal VirtualMachineImageResource(string id, string name, string location, IDictionary<string, string> tags) : base(id)
        {
            Name = name;
            Location = location;
            Tags = tags;
        }

        /// <summary> The name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> The supported Azure location of the resource. </summary>
        public string Location { get; set; }
        /// <summary> Specifies the tags that are assigned to the virtual machine. For more information about using tags, see [Using tags to organize your Azure resources](https://docs.microsoft.com/azure/azure-resource-manager/resource-group-using-tags.md). </summary>
        public IDictionary<string, string> Tags { get; }
    }
}

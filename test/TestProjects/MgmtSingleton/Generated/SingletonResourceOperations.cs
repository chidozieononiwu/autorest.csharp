// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtSingleton
{
    /// <summary> A class representing the operations that can be performed over a specific SingletonResource. </summary>
    public partial class SingletonResourceOperations : SingletonOperationsBase<ResourceGroupResourceIdentifier, SingletonResource>
    {
        /// <summary> Initializes a new instance of the <see cref="SingletonResourceOperations"/> class for mocking. </summary>
        protected SingletonResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SingletonResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        protected internal SingletonResourceOperations(ResourceOperationsBase options) : base(options)
        {
        }

        public static readonly ResourceType ResourceType = "Microsoft.Billing/parentResources/singletonResources";
        protected override ResourceType ValidResourceType => ResourceType;
    }
}

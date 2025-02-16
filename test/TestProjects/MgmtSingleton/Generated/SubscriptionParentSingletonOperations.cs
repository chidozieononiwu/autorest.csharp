// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtSingleton
{
    /// <summary> A class representing the operations that can be performed over a specific SubscriptionParentSingleton. </summary>
    public partial class SubscriptionParentSingletonOperations : SingletonOperationsBase<SubscriptionResourceIdentifier, SubscriptionParentSingleton>
    {
        /// <summary> Initializes a new instance of the <see cref="SubscriptionParentSingletonOperations"/> class for mocking. </summary>
        protected SubscriptionParentSingletonOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionParentSingletonOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        protected internal SubscriptionParentSingletonOperations(ResourceOperationsBase options) : base(options)
        {
        }

        public static readonly ResourceType ResourceType = "Microsoft.Billing/SubscriptionParentSingleton/default";
        protected override ResourceType ValidResourceType => ResourceType;
    }
}

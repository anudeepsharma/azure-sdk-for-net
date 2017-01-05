// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using Models;
    using System;

    /// <summary>
    /// An immutable client-side representation of an Azure SQL database's Upgrade hint.
    /// </summary>
    public interface IUpgradeHintInterface  :
        IWrapper<Models.UpgradeHint>
    {
        /// <summary>
        /// Gets Target ServiceLevelObjectiveId for upgrade hint.
        /// </summary>
        System.Guid TargetServiceLevelObjectiveId { get; }

        /// <summary>
        /// Gets Target ServiceLevelObjective for upgrade hint.
        /// </summary>
        string TargetServiceLevelObjective { get; }
    }
}
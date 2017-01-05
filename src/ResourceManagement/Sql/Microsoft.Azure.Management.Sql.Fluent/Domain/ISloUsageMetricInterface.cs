// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using Models;
    using System;

    /// <summary>
    /// An immutable client-side representation of an Azure SQL database's SloUsageMetric.
    /// </summary>
    public interface ISloUsageMetricInterface  :
        IWrapper<Models.SloUsageMetric>
    {
        /// <summary>
        /// Gets the serviceLevelObjectiveId for SLO usage metric.
        /// </summary>
        System.Guid ServiceLevelObjectiveId { get; }

        /// <summary>
        /// Gets the serviceLevelObjective for SLO usage metric.
        /// </summary>
        string ServiceLevelObjective { get; }

        /// <summary>
        /// Gets inRangeTimeRatio for SLO usage metric.
        /// </summary>
        double InRangeTimeRatio { get; }
    }
}
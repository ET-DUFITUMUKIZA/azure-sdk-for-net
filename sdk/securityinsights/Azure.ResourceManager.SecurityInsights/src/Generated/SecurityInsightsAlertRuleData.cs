// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsAlertRule data model.
    /// Please note <see cref="SecurityInsightsAlertRuleData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FusionAlertRule"/>, <see cref="MLBehaviorAnalyticsAlertRule"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRule"/>, <see cref="NrtAlertRule"/>, <see cref="ScheduledAlertRule"/> and <see cref="ThreatIntelligenceAlertRule"/>.
    /// </summary>
    public partial class SecurityInsightsAlertRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of SecurityInsightsAlertRuleData. </summary>
        public SecurityInsightsAlertRuleData()
        {
        }

        /// <summary> Initializes a new instance of SecurityInsightsAlertRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        internal SecurityInsightsAlertRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ETag = etag;
        }

        /// <summary> The kind of the alert rule. </summary>
        internal AlertRuleKind Kind { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}

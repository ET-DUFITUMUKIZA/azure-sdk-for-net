// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The ReservationRefundResponseProperties. </summary>
    public partial class ReservationRefundResponseProperties
    {
        /// <summary> Initializes a new instance of ReservationRefundResponseProperties. </summary>
        internal ReservationRefundResponseProperties()
        {
        }

        /// <summary> Initializes a new instance of ReservationRefundResponseProperties. </summary>
        /// <param name="sessionId"> Refund session identifier. </param>
        /// <param name="quantity"> Quantity to be returned. </param>
        /// <param name="billingRefundAmount"></param>
        /// <param name="pricingRefundAmount"></param>
        /// <param name="policyResult"> Refund policy result. </param>
        /// <param name="billingInformation"> billing information. </param>
        internal ReservationRefundResponseProperties(Guid? sessionId, int? quantity, PurchasePrice billingRefundAmount, PurchasePrice pricingRefundAmount, RefundPolicyResult policyResult, ReservationRefundBillingInformation billingInformation)
        {
            SessionId = sessionId;
            Quantity = quantity;
            BillingRefundAmount = billingRefundAmount;
            PricingRefundAmount = pricingRefundAmount;
            PolicyResult = policyResult;
            BillingInformation = billingInformation;
        }

        /// <summary> Refund session identifier. </summary>
        public Guid? SessionId { get; }
        /// <summary> Quantity to be returned. </summary>
        public int? Quantity { get; }
        /// <summary> Gets the billing refund amount. </summary>
        public PurchasePrice BillingRefundAmount { get; }
        /// <summary> Gets the pricing refund amount. </summary>
        public PurchasePrice PricingRefundAmount { get; }
        /// <summary> Refund policy result. </summary>
        internal RefundPolicyResult PolicyResult { get; }
        /// <summary> Refund policy result property. </summary>
        public ReservationRefundPolicyResultProperty PolicyResultProperties
        {
            get => PolicyResult?.Properties;
        }

        /// <summary> billing information. </summary>
        public ReservationRefundBillingInformation BillingInformation { get; }
    }
}

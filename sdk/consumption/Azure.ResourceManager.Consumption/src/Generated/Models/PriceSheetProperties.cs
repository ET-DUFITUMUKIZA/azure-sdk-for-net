// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The properties of the price sheet. </summary>
    public partial class PriceSheetProperties
    {
        /// <summary> Initializes a new instance of PriceSheetProperties. </summary>
        internal PriceSheetProperties()
        {
        }

        /// <summary> Initializes a new instance of PriceSheetProperties. </summary>
        /// <param name="billingPeriodId"> The id of the billing period resource that the usage belongs to. </param>
        /// <param name="meterId"> The meter id (GUID). </param>
        /// <param name="meterDetails"> The details about the meter. By default this is not populated, unless it&apos;s specified in $expand. </param>
        /// <param name="unitOfMeasure"> Unit of measure. </param>
        /// <param name="includedQuantity"> Included quality for an offer. </param>
        /// <param name="partNumber"> Part Number. </param>
        /// <param name="unitPrice"> Unit Price. </param>
        /// <param name="currencyCode"> Currency Code. </param>
        /// <param name="offerId"> Offer Id. </param>
        internal PriceSheetProperties(ResourceIdentifier billingPeriodId, Guid? meterId, ConsumptionMeterDetails meterDetails, string unitOfMeasure, decimal? includedQuantity, string partNumber, decimal? unitPrice, string currencyCode, string offerId)
        {
            BillingPeriodId = billingPeriodId;
            MeterId = meterId;
            MeterDetails = meterDetails;
            UnitOfMeasure = unitOfMeasure;
            IncludedQuantity = includedQuantity;
            PartNumber = partNumber;
            UnitPrice = unitPrice;
            CurrencyCode = currencyCode;
            OfferId = offerId;
        }

        /// <summary> The id of the billing period resource that the usage belongs to. </summary>
        public ResourceIdentifier BillingPeriodId { get; }
        /// <summary> The meter id (GUID). </summary>
        public Guid? MeterId { get; }
        /// <summary> The details about the meter. By default this is not populated, unless it&apos;s specified in $expand. </summary>
        public ConsumptionMeterDetails MeterDetails { get; }
        /// <summary> Unit of measure. </summary>
        public string UnitOfMeasure { get; }
        /// <summary> Included quality for an offer. </summary>
        public decimal? IncludedQuantity { get; }
        /// <summary> Part Number. </summary>
        public string PartNumber { get; }
        /// <summary> Unit Price. </summary>
        public decimal? UnitPrice { get; }
        /// <summary> Currency Code. </summary>
        public string CurrencyCode { get; }
        /// <summary> Offer Id. </summary>
        public string OfferId { get; }
    }
}

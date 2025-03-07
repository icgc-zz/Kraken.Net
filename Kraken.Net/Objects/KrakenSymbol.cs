﻿using System;
using System.Collections.Generic;
using CryptoExchange.Net.ExchangeInterfaces;
using Newtonsoft.Json;

namespace Kraken.Net.Objects
{
    /// <summary>
    /// Symbol info
    /// </summary>
    public class KrakenSymbol: ICommonSymbol
    {
        /// <summary>
        /// Alternative name
        /// </summary>
        [JsonProperty("altname")]
        public string AlternateName { get; set; } = string.Empty;
        /// <summary>
        /// Name to use for the socket client subscriptions
        /// </summary>
        [JsonProperty("wsname")]
        public string WebsocketName { get; set; } = string.Empty;
        /// <summary>
        /// Class of the base asset
        /// </summary>
        [JsonProperty("aclass_base")]
        public string BaseAssetClass { get; set; } = string.Empty;
        /// <summary>
        /// Name of the base asset
        /// </summary>
        [JsonProperty("base")]
        public string BaseAsset { get; set; } = string.Empty;
        /// <summary>
        /// Class of the quote asset
        /// </summary>
        [JsonProperty("aclass_quote")]
        public string QuoteAssetClass { get; set; } = string.Empty;
        /// <summary>
        /// Name of the quote asset
        /// </summary>
        [JsonProperty("quote")]
        public string QuoteAsset { get; set; } = string.Empty;
        /// <summary>
        /// Let size
        /// </summary>
        [JsonProperty("lot")]
        public string VolumeLotSize { get; set; } = string.Empty;
        /// <summary>
        /// Decimals of the symbol
        /// </summary>
        [JsonProperty("pair_decimals")]
        public int Decimals { get; set; }
        /// <summary>
        /// Lot decimals
        /// </summary>
        [JsonProperty("lot_decimals")]
        public int LotDecimals { get; set; }
        /// <summary>
        /// Lot multiplier
        /// </summary>
        [JsonProperty("lot_multiplier")]
        public decimal LotMultiplier { get; set; }
        /// <summary>
        /// Buy leverage amounts
        /// </summary>
        [JsonProperty("leverage_buy")]
        public IEnumerable<decimal> LeverageBuy { get; set; } = Array.Empty<decimal>();
        /// <summary>
        /// Sell leverage amounts
        /// </summary>
        [JsonProperty("leverage_sell")]
        public IEnumerable<decimal> LeverageSell { get; set; } = Array.Empty<decimal>();
        /// <summary>
        /// Fee structure
        /// </summary>
        public IEnumerable<KrakenFeeEntry> Fees { get; set; } = Array.Empty<KrakenFeeEntry>();
        /// <summary>
        /// Maker fee structure
        /// </summary>
        [JsonProperty("fees_maker")]
        public IEnumerable<KrakenFeeEntry> FeesMaker { get; set; } = Array.Empty<KrakenFeeEntry>();

        /// <summary>
        /// The currency the fee is deducted from
        /// </summary>
        [JsonProperty("fee_volume_currency")]
        public string FeeCurrency { get; set; } = string.Empty;
        /// <summary>
        /// Margin call level
        /// </summary>
        [JsonProperty("margin_call")]
        public int MarginCall { get; set; }
        /// <summary>
        /// Stop-out/liquidation margin level
        /// </summary>
        [JsonProperty("margin_stop")]
        public int MarginStop { get; set; }
        /// <summary>
        /// The minimum order volume for pair
        /// </summary>
        /// <value></value>
        [JsonProperty("ordermin")]
        public decimal OrderMin { get; set; }

        string ICommonSymbol.CommonName => BaseAsset + QuoteAsset;
        decimal ICommonSymbol.CommonMinimumTradeSize => OrderMin;
    }
}

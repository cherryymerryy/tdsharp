using System;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Describes an upgraded gift that can be gifted to another user or transferred to TON blockchain as an NFT
        /// </summary>
        public partial class UpgradedGift : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "upgradedGift";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of the gift
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public long Id { get; set; }

            /// <summary>
            /// The title of the upgraded gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Unique number of the upgraded gift among gifts upgraded from the same gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("number")]
            public int Number { get; set; }

            /// <summary>
            /// Total number of gifts that were upgraded from the same gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("total_upgraded_count")]
            public int TotalUpgradedCount { get; set; }

            /// <summary>
            /// The maximum number of gifts that can be upgraded from the same gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("max_upgraded_count")]
            public int MaxUpgradedCount { get; set; }

            /// <summary>
            /// User identifier of the user that owns the upgraded gift; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("owner_user_id")]
            public long OwnerUserId { get; set; }

            /// <summary>
            /// Model of the upgraded gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("model")]
            public UpgradedGiftModel Model { get; set; }

            /// <summary>
            /// Symbol of the upgraded gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("symbol")]
            public UpgradedGiftSymbol Symbol { get; set; }

            /// <summary>
            /// Backdrop of the upgraded gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("backdrop")]
            public UpgradedGiftBackdrop Backdrop { get; set; }

            /// <summary>
            /// Information about the originally sent gift; may be null if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("original_details")]
            public UpgradedGiftOriginalDetails OriginalDetails { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
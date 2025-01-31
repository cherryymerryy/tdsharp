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
        /// Contains result of gift upgrading
        /// </summary>
        public partial class UpgradeGiftResult : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "upgradeGiftResult";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The upgraded gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("gift")]
            public UpgradedGift Gift { get; set; }

            /// <summary>
            /// True, if the gift is displayed on the user's profile page
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_saved")]
            public bool IsSaved { get; set; }

            /// <summary>
            /// True, if the gift can be transferred to another user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_be_transferred")]
            public bool CanBeTransferred { get; set; }

            /// <summary>
            /// Number of Telegram Stars that must be paid to transfer the upgraded gift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("transfer_star_count")]
            public long TransferStarCount { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the gift can be transferred to TON blockchain as an NFT
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("export_date")]
            public int ExportDate { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
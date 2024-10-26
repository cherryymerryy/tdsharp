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
        public partial class TelegramPaymentPurpose : Object
        {
            /// <summary>
            /// The user buying Telegram Stars for other users
            /// </summary>
            public class TelegramPaymentPurposeGiftedStars : TelegramPaymentPurpose
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "telegramPaymentPurposeGiftedStars";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the user to which Telegram Stars are gifted
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public long UserId { get; set; }

                /// <summary>
                /// ISO 4217 currency code of the payment currency
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("currency")]
                public string Currency { get; set; }

                /// <summary>
                /// Paid amount, in the smallest units of the currency
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("amount")]
                public long Amount { get; set; }

                /// <summary>
                /// Number of bought Telegram Stars
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("star_count")]
                public long StarCount { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
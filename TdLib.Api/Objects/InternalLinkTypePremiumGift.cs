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
        public partial class InternalLinkType : Object
        {
            /// <summary>
            /// The link is a link to the screen for gifting Telegram Premium subscriptions to friends via inputInvoiceTelegram payments or in-store purchases
            /// </summary>
            public class InternalLinkTypePremiumGift : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypePremiumGift";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Referrer specified in the link
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("referrer")]
                public string Referrer { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
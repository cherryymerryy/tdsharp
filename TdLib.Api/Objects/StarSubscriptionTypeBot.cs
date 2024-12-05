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
        public partial class StarSubscriptionType : Object
        {
            /// <summary>
            /// Describes a subscription in a bot or a business account
            /// </summary>
            public class StarSubscriptionTypeBot : StarSubscriptionType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "starSubscriptionTypeBot";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// True, if the subscription was canceled by the bot and can't be extended
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_canceled_by_bot")]
                public bool IsCanceledByBot { get; set; }

                /// <summary>
                /// Subscription invoice title
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// Subscription invoice photo
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public Photo Photo { get; set; }

                /// <summary>
                /// The link to the subscription invoice
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("invoice_link")]
                public string InvoiceLink { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
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
        /// Describes an affiliate program that was connected to a chat
        /// </summary>
        public partial class ChatAffiliateProgram : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatAffiliateProgram";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The link that can be used to refer users if the program is still active
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// User identifier of the bot created the program
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public long BotUserId { get; set; }

            /// <summary>
            /// The parameters of the affiliate program
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("parameters")]
            public AffiliateProgramParameters Parameters { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the affiliate program was connected
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("connection_date")]
            public int ConnectionDate { get; set; }

            /// <summary>
            /// True, if the program was canceled by the bot, or disconnected by the chat owner and isn't available anymore
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_disconnected")]
            public bool IsDisconnected { get; set; }

            /// <summary>
            /// The number of users that used the affiliate program
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("user_count")]
            public long UserCount { get; set; }

            /// <summary>
            /// The number of Telegram Stars that were earned by the affiliate program
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("revenue_star_count")]
            public long RevenueStarCount { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
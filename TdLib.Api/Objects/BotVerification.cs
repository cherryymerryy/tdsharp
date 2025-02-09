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
        /// Describes verification status provided by a bot
        /// </summary>
        public partial class BotVerification : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "botVerification";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the bot that provided the verification
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public long BotUserId { get; set; }

            /// <summary>
            /// Identifier of the custom emoji that is used as the verification sign
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("icon_custom_emoji_id")]
            public long IconCustomEmojiId { get; set; }

            /// <summary>
            /// Custom description of verification reason set by the bot. Can contain only Mention, Hashtag, Cashtag, PhoneNumber, BankCardNumber, Url, and EmailAddress entities
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("custom_description")]
            public FormattedText CustomDescription { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
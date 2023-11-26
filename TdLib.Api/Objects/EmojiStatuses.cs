using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains a list of custom emoji identifiers, which can be set as emoji statuses
        /// </summary>
        public partial class EmojiStatuses : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "emojiStatuses";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The list of custom emoji identifiers
            /// </summary>
            [JsonProperty("custom_emoji_ids", ItemConverterType = typeof(Converter))]
            public long[] CustomEmojiIds { get; set; }
        }
    }
}
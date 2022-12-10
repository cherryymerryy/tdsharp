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
        /// Represents a list of reactions that can be added to a message
        /// </summary>
        public partial class AvailableReactions : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "availableReactions";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of reactions to be shown at the top
            /// </summary>
            [JsonProperty("top_reactions", ItemConverterType = typeof(Converter))]
            public AvailableReaction[] TopReactions { get; set; }

            /// <summary>
            /// List of recently used reactions
            /// </summary>
            [JsonProperty("recent_reactions", ItemConverterType = typeof(Converter))]
            public AvailableReaction[] RecentReactions { get; set; }

            /// <summary>
            /// List of popular reactions
            /// </summary>
            [JsonProperty("popular_reactions", ItemConverterType = typeof(Converter))]
            public AvailableReaction[] PopularReactions { get; set; }

            /// <summary>
            /// True, if custom emoji reactions could be added by Telegram Premium subscribers
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("allow_custom_emoji")]
            public bool AllowCustomEmoji { get; set; }
        }
    }
}
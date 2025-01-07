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
        /// Describes name of a chat folder
        /// </summary>
        public partial class ChatFolderName : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatFolderName";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The text of the chat folder name; 1-12 characters without line feeds. May contain only CustomEmoji entities
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public FormattedText Text { get; set; }

            /// <summary>
            /// True, if custom emoji in the name must be animated
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("animate_custom_emoji")]
            public bool AnimateCustomEmoji { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
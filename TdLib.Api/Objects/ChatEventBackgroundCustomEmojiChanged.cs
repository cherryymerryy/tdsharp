using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The chat's custom emoji for reply background was changed
            /// </summary>
            public class ChatEventBackgroundCustomEmojiChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventBackgroundCustomEmojiChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous identifier of the custom emoji; 0 if none
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("old_background_custom_emoji_id")]
                public long OldBackgroundCustomEmojiId { get; set; }

                /// <summary>
                /// New identifier of the custom emoji; 0 if none
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("new_background_custom_emoji_id")]
                public long NewBackgroundCustomEmojiId { get; set; }
            }
        }
    }
}
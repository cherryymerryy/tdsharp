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
        public partial class InputMessageContent : Object
        {
            /// <summary>
            /// A message with a forwarded story. Stories can't be sent to secret chats. A story can be forwarded only if story.can_be_forwarded
            /// </summary>
            public class InputMessageStory : InputMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessageStory";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the chat that posted the story
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("story_sender_chat_id")]
                public long StorySenderChatId { get; set; }

                /// <summary>
                /// Story identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("story_id")]
                public int StoryId { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
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
        public partial class TargetChat : Object
        {
            /// <summary>
            /// The chat needs to be chosen by the user among chats of the specified types
            /// </summary>
            public class TargetChatChosen : TargetChat
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "targetChatChosen";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Allowed types for the chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("types")]
                public TargetChatTypes Types { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageContent : Object
        {
            /// <summary>
            /// The chat was boosted by the sender of the message
            /// </summary>
            public class MessageChatBoost : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageChatBoost";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Number of times the chat was boosted
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("boost_count")]
                public int BoostCount { get; set; }
            }
        }
    }
}
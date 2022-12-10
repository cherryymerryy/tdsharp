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
        /// Represents a list of message senders, which can be used to send messages in a chat
        /// </summary>
        public partial class ChatMessageSenders : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatMessageSenders";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of available message senders
            /// </summary>
            [JsonProperty("senders", ItemConverterType = typeof(Converter))]
            public ChatMessageSender[] Senders { get; set; }
        }
    }
}
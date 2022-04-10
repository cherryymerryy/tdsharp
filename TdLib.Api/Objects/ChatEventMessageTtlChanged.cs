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
            /// The message TTL was changed
            /// </summary>
            public class ChatEventMessageTtlChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventMessageTtlChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous value of message_ttl
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_message_ttl")]
                public int OldMessageTtl { get; set; }

                /// <summary>
                /// New value of message_ttl
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_message_ttl")]
                public int NewMessageTtl { get; set; }
            }
        }
    }
}
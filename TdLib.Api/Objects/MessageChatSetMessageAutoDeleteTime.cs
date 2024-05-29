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
            /// The auto-delete or self-destruct timer for messages in the chat has been changed
            /// </summary>
            public class MessageChatSetMessageAutoDeleteTime : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageChatSetMessageAutoDeleteTime";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// New value auto-delete or self-destruct time, in seconds; 0 if disabled
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_auto_delete_time")]
                public int MessageAutoDeleteTime { get; set; }

                /// <summary>
                /// If not 0, a user identifier, which default setting was automatically applied
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("from_user_id")]
                public long FromUserId { get; set; }
            }
        }
    }
}
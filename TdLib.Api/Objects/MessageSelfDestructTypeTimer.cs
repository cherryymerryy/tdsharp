using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageSelfDestructType : Object
        {
            /// <summary>
            /// Describes when a message will be self-destructed
            /// </summary>
            public class MessageSelfDestructTypeTimer : MessageSelfDestructType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageSelfDestructTypeTimer";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The message's self-destruct time, in seconds; must be between 0 and 60 in private chats
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("self_destruct_time")]
                public int SelfDestructTime { get; set; }
            }
        }
    }
}
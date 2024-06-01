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
        public partial class CanSendStoryResult : Object
        {
            /// <summary>
            /// The chat must be boosted first by Telegram Premium subscribers to post more stories. Call getChatBoostStatus to get current boost status of the chat
            /// </summary>
            public class CanSendStoryResultBoostNeeded : CanSendStoryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "canSendStoryResultBoostNeeded";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
// REUSE-IgnoreEnd
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
        public partial class ChatTransactionPurpose : Object
        {
            /// <summary>
            /// User paid for a reaction
            /// </summary>
            public class ChatTransactionPurposeReaction : ChatTransactionPurpose
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatTransactionPurposeReaction";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the reacted message; can be 0 or an identifier of a deleted message
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
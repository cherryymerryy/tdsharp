using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class CanTransferOwnershipResult : Object
        {
            /// <summary>
            /// The session was created recently, user needs to wait
            /// </summary>
            public class CanTransferOwnershipResultSessionTooFresh : CanTransferOwnershipResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "canTransferOwnershipResultSessionTooFresh";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Time left before the session can be used to transfer ownership of a chat, in seconds
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("retry_after")]
                public int RetryAfter { get; set; }
            }
        }
    }
}
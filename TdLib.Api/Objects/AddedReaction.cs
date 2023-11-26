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
        /// Represents a reaction applied to a message
        /// </summary>
        public partial class AddedReaction : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addedReaction";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Type of the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public ReactionType Type { get; set; }

            /// <summary>
            /// Identifier of the chat member, applied the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sender_id")]
            public MessageSender SenderId { get; set; }

            /// <summary>
            /// True, if the reaction was added by the current user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_outgoing")]
            public bool IsOutgoing { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the reaction was added
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }
        }
    }
}
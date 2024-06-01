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
        /// <summary>
        /// Contains information about a forwarded message
        /// </summary>
        public partial class MessageForwardInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageForwardInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Origin of the forwarded message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("origin")]
            public MessageOrigin Origin { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the message was originally sent
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }

            /// <summary>
            /// For messages forwarded to the chat with the current user (Saved Messages), to the Replies bot chat, or to the channel's discussion group, information about the source message from which the message was forwarded last time; may be null for other forwards or if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("source")]
            public ForwardSource Source { get; set; }

            /// <summary>
            /// The type of public service announcement for the forwarded message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("public_service_announcement_type")]
            public string PublicServiceAnnouncementType { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
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
        /// Information about the sponsor of a message
        /// </summary>
        public partial class MessageSponsor : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageSponsor";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Type of the sponsor
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public MessageSponsorType Type { get; set; }

            /// <summary>
            /// Photo of the sponsor; may be null if must not be shown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public ChatPhotoInfo Photo { get; set; }

            /// <summary>
            /// Additional optional information about the sponsor to be shown along with the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("info")]
            public string Info { get; set; }
        }
    }
}
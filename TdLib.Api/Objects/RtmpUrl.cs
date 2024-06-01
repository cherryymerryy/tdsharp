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
        /// Represents an RTMP URL
        /// </summary>
        public partial class RtmpUrl : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "rtmpUrl";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The URL
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// Stream key
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("stream_key")]
            public string StreamKey { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
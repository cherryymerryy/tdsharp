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
        /// Describes a notification sound in MP3 format
        /// </summary>
        public partial class NotificationSound : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "notificationSound";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of the notification sound
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public long Id { get; set; }

            /// <summary>
            /// Duration of the sound, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("duration")]
            public int Duration { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the sound was created
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }

            /// <summary>
            /// Title of the notification sound
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Arbitrary data, defined while the sound was uploaded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("data")]
            public string Data { get; set; }

            /// <summary>
            /// File containing the sound
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sound")]
            public File Sound { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
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
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A photo message
            /// </summary>
            public class MessagePhoto : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messagePhoto";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The photo
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public Photo Photo { get; set; }

                /// <summary>
                /// Photo caption
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText Caption { get; set; }

                /// <summary>
                /// True, if the photo preview must be covered by a spoiler animation
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("has_spoiler")]
                public bool HasSpoiler { get; set; }

                /// <summary>
                /// True, if the photo must be blurred and must be shown only while tapped
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_secret")]
                public bool IsSecret { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
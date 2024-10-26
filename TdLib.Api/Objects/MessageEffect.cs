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
        /// Contains information about an effect added to a message
        /// </summary>
        public partial class MessageEffect : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageEffect";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of the effect
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public long Id { get; set; }

            /// <summary>
            /// Static icon for the effect in WEBP format; may be null if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("static_icon")]
            public Sticker StaticIcon { get; set; }

            /// <summary>
            /// Emoji corresponding to the effect that can be used if static icon isn't available
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("emoji")]
            public string Emoji { get; set; }

            /// <summary>
            /// True, if Telegram Premium subscription is required to use the effect
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_premium")]
            public bool IsPremium { get; set; }

            /// <summary>
            /// Type of the effect
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public MessageEffectType Type { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
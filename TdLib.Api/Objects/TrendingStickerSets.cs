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
        /// Represents a list of trending sticker sets
        /// </summary>
        public partial class TrendingStickerSets : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "trendingStickerSets";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Approximate total number of trending sticker sets
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("total_count")]
            public int TotalCount { get; set; }

            /// <summary>
            /// List of trending sticker sets
            /// </summary>
            [JsonProperty("sets", ItemConverterType = typeof(Converter))]
            public StickerSetInfo[] Sets { get; set; }

            /// <summary>
            /// True, if the list contains sticker sets with premium stickers
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_premium")]
            public bool IsPremium { get; set; }
        }
    }
}
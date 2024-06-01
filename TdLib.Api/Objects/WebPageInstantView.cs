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
        /// Describes an instant view page for a web page
        /// </summary>
        public partial class WebPageInstantView : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "webPageInstantView";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Content of the web page
            /// </summary>
            [JsonProperty("page_blocks", ItemConverterType = typeof(Converter))]
            public PageBlock[] PageBlocks { get; set; }

            /// <summary>
            /// Number of the instant view views; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("view_count")]
            public int ViewCount { get; set; }

            /// <summary>
            /// Version of the instant view; currently, can be 1 or 2
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("version")]
            public int Version { get; set; }

            /// <summary>
            /// True, if the instant view must be shown from right to left
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_rtl")]
            public bool IsRtl { get; set; }

            /// <summary>
            /// True, if the instant view contains the full page. A network request might be needed to get the full web page instant view
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_full")]
            public bool IsFull { get; set; }

            /// <summary>
            /// An internal link to be opened to leave feedback about the instant view
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("feedback_link")]
            public InternalLinkType FeedbackLink { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
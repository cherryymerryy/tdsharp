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
        /// Represents a list of found affiliate programs
        /// </summary>
        public partial class FoundAffiliatePrograms : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "foundAffiliatePrograms";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The total number of found affiliate programs
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("total_count")]
            public int TotalCount { get; set; }

            /// <summary>
            /// The list of affiliate programs
            /// </summary>
            [JsonProperty("programs", ItemConverterType = typeof(Converter))]
            public FoundAffiliateProgram[] Programs { get; set; }

            /// <summary>
            /// The offset for the next request. If empty, then there are no more results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("next_offset")]
            public string NextOffset { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
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
        /// Represents a list of proxy servers
        /// </summary>
        public partial class Proxies : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "proxies";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of proxy servers
            /// </summary>
            [JsonProperty("proxies", ItemConverterType = typeof(Converter))]
            public Proxy[] Proxies_ { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
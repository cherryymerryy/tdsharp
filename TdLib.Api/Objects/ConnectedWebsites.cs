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
        /// Contains a list of websites the current user is logged in with Telegram
        /// </summary>
        public partial class ConnectedWebsites : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "connectedWebsites";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of connected websites
            /// </summary>
            [JsonProperty("websites", ItemConverterType = typeof(Converter))]
            public ConnectedWebsite[] Websites { get; set; }
        }
    }
}
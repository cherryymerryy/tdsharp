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
        /// Contains information about saved payment credentials
        /// </summary>
        public partial class SavedCredentials : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "savedCredentials";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of the saved credentials
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public string Id { get; set; }

            /// <summary>
            /// Title of the saved credentials
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }
        }
    }
}
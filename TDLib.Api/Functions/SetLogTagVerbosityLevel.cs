using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Sets the verbosity level for a specified TDLib internal log tag. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public class SetLogTagVerbosityLevel : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setLogTagVerbosityLevel";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Logging tag to change verbosity level 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("tag")]
            public string Tag { get; set; }

            /// <summary>
            /// New verbosity level; 1-1024
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("new_verbosity_level")]
            public int NewVerbosityLevel { get; set; }
        }
    }
}
using System;
using System.Threading.Tasks;
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
        /// Adds a message to TDLib internal log. Can be called synchronously
        /// </summary>
        public class AddLogMessage : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addLogMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The minimum verbosity level needed for the message to be logged; 0-1023
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("verbosity_level")]
            public int VerbosityLevel { get; set; }

            /// <summary>
            /// Text of a message to log
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public string Text { get; set; }
        }

        /// <summary>
        /// Adds a message to TDLib internal log. Can be called synchronously
        /// </summary>
        public static Task<Ok> AddLogMessageAsync(
            this Client client, int verbosityLevel = default, string text = default)
        {
            return client.ExecuteAsync(new AddLogMessage
            {
                VerbosityLevel = verbosityLevel, Text = text
            });
        }
    }
}
// REUSE-IgnoreEnd
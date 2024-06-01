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
        /// Sends debug information for a call to Telegram servers
        /// </summary>
        public class SendCallDebugInformation : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendCallDebugInformation";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("call_id")]
            public int CallId { get; set; }

            /// <summary>
            /// Debug information in application-specific format
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("debug_information")]
            public string DebugInformation { get; set; }
        }

        /// <summary>
        /// Sends debug information for a call to Telegram servers
        /// </summary>
        public static Task<Ok> SendCallDebugInformationAsync(
            this Client client, int callId = default, string debugInformation = default)
        {
            return client.ExecuteAsync(new SendCallDebugInformation
            {
                CallId = callId, DebugInformation = debugInformation
            });
        }
    }
}
// REUSE-IgnoreEnd
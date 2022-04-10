using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Starts screen sharing in a joined group call. Returns join response payload for tgcalls
        /// </summary>
        public class StartGroupCallScreenSharing : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "startGroupCallScreenSharing";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_call_id")]
            public int GroupCallId { get; set; }

            /// <summary>
            /// Screen sharing audio channel synchronization source identifier; received from tgcalls
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("audio_source_id")]
            public int AudioSourceId { get; set; }

            /// <summary>
            /// Group call join payload; received from tgcalls
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("payload")]
            public string Payload { get; set; }
        }

        /// <summary>
        /// Starts screen sharing in a joined group call. Returns join response payload for tgcalls
        /// </summary>
        public static Task<Text> StartGroupCallScreenSharingAsync(
            this Client client, int groupCallId = default, int audioSourceId = default, string payload = default)
        {
            return client.ExecuteAsync(new StartGroupCallScreenSharing
            {
                GroupCallId = groupCallId, AudioSourceId = audioSourceId, Payload = payload
            });
        }
    }
}
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
        /// Pauses or unpauses screen sharing in a joined group call
        /// </summary>
        public class ToggleGroupCallScreenSharingIsPaused : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleGroupCallScreenSharingIsPaused";

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
            /// Pass true to pause screen sharing; pass false to unpause it
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_paused")]
            public bool IsPaused { get; set; }
        }

        /// <summary>
        /// Pauses or unpauses screen sharing in a joined group call
        /// </summary>
        public static Task<Ok> ToggleGroupCallScreenSharingIsPausedAsync(
            this Client client, int groupCallId = default, bool isPaused = default)
        {
            return client.ExecuteAsync(new ToggleGroupCallScreenSharingIsPaused
            {
                GroupCallId = groupCallId, IsPaused = isPaused
            });
        }
    }
}
// REUSE-IgnoreEnd
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
        /// Informs TDLib that speaking state of a participant of an active group has changed
        /// </summary>
        public class SetGroupCallParticipantIsSpeaking : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setGroupCallParticipantIsSpeaking";

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
            /// Group call participant's synchronization audio source identifier, or 0 for the current user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("audio_source")]
            public int AudioSource { get; set; }

            /// <summary>
            /// Pass true if the user is speaking
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_speaking")]
            public bool IsSpeaking { get; set; }
        }

        /// <summary>
        /// Informs TDLib that speaking state of a participant of an active group has changed
        /// </summary>
        public static Task<Ok> SetGroupCallParticipantIsSpeakingAsync(
            this Client client, int groupCallId = default, int audioSource = default, bool isSpeaking = default)
        {
            return client.ExecuteAsync(new SetGroupCallParticipantIsSpeaking
            {
                GroupCallId = groupCallId, AudioSource = audioSource, IsSpeaking = isSpeaking
            });
        }
    }
}
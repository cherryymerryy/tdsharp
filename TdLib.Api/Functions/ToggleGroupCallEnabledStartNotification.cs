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
        /// Toggles whether the current user will receive a notification when the group call starts; scheduled group calls only
        /// </summary>
        public class ToggleGroupCallEnabledStartNotification : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleGroupCallEnabledStartNotification";

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
            /// New value of the enabled_start_notification setting
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("enabled_start_notification")]
            public bool EnabledStartNotification { get; set; }
        }

        /// <summary>
        /// Toggles whether the current user will receive a notification when the group call starts; scheduled group calls only
        /// </summary>
        public static Task<Ok> ToggleGroupCallEnabledStartNotificationAsync(
            this Client client, int groupCallId = default, bool enabledStartNotification = default)
        {
            return client.ExecuteAsync(new ToggleGroupCallEnabledStartNotification
            {
                GroupCallId = groupCallId, EnabledStartNotification = enabledStartNotification
            });
        }
    }
}
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
        /// Resets all notification settings to their default values. By default, all chats are unmuted and message previews are shown
        /// </summary>
        public class ResetAllNotificationSettings : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resetAllNotificationSettings";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Resets all notification settings to their default values. By default, all chats are unmuted and message previews are shown
        /// </summary>
        public static Task<Ok> ResetAllNotificationSettingsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new ResetAllNotificationSettings
            {
                
            });
        }
    }
}
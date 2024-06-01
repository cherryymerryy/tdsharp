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
        /// Changes notification settings for reactions
        /// </summary>
        public class SetReactionNotificationSettings : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setReactionNotificationSettings";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new notification settings for reactions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("notification_settings")]
            public ReactionNotificationSettings NotificationSettings { get; set; }
        }

        /// <summary>
        /// Changes notification settings for reactions
        /// </summary>
        public static Task<Ok> SetReactionNotificationSettingsAsync(
            this Client client, ReactionNotificationSettings notificationSettings = default)
        {
            return client.ExecuteAsync(new SetReactionNotificationSettings
            {
                NotificationSettings = notificationSettings
            });
        }
    }
}
// REUSE-IgnoreEnd
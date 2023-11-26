using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// A list of active notifications in a notification group has changed
            /// </summary>
            public class UpdateNotificationGroup : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateNotificationGroup";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique notification group identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("notification_group_id")]
                public int NotificationGroupId { get; set; }

                /// <summary>
                /// New type of the notification group
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("type")]
                public NotificationGroupType Type { get; set; }

                /// <summary>
                /// Identifier of a chat to which all notifications in the group belong
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                /// <summary>
                /// Chat identifier, which notification settings must be applied to the added notifications
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("notification_settings_chat_id")]
                public long NotificationSettingsChatId { get; set; }

                /// <summary>
                /// Identifier of the notification sound to be played; 0 if sound is disabled
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("notification_sound_id")]
                public long NotificationSoundId { get; set; }

                /// <summary>
                /// Total number of unread notifications in the group, can be bigger than number of active notifications
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// List of added group notifications, sorted by notification identifier
                /// </summary>
                [JsonProperty("added_notifications", ItemConverterType = typeof(Converter))]
                public Notification[] AddedNotifications { get; set; }

                /// <summary>
                /// Identifiers of removed group notifications, sorted by notification identifier
                /// </summary>
                [JsonProperty("removed_notification_ids", ItemConverterType = typeof(Converter))]
                public int[] RemovedNotificationIds { get; set; }
            }
        }
    }
}
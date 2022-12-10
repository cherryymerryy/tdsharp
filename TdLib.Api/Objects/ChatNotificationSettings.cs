using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains information about notification settings for a chat or a froum topic
        /// </summary>
        public partial class ChatNotificationSettings : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatNotificationSettings";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// If true, mute_for is ignored and the value for the relevant type of chat or the forum chat is used instead
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_default_mute_for")]
            public bool UseDefaultMuteFor { get; set; }

            /// <summary>
            /// Time left before notifications will be unmuted, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("mute_for")]
            public int MuteFor { get; set; }

            /// <summary>
            /// If true, the value for the relevant type of chat or the forum chat is used instead of sound_id
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_default_sound")]
            public bool UseDefaultSound { get; set; }

            /// <summary>
            /// Identifier of the notification sound to be played; 0 if sound is disabled
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("sound_id")]
            public long SoundId { get; set; }

            /// <summary>
            /// If true, show_preview is ignored and the value for the relevant type of chat or the forum chat is used instead
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_default_show_preview")]
            public bool UseDefaultShowPreview { get; set; }

            /// <summary>
            /// True, if message content must be displayed in notifications
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("show_preview")]
            public bool ShowPreview { get; set; }

            /// <summary>
            /// If true, disable_pinned_message_notifications is ignored and the value for the relevant type of chat or the forum chat is used instead
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_default_disable_pinned_message_notifications")]
            public bool UseDefaultDisablePinnedMessageNotifications { get; set; }

            /// <summary>
            /// If true, notifications for incoming pinned messages will be created as for an ordinary unread message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("disable_pinned_message_notifications")]
            public bool DisablePinnedMessageNotifications { get; set; }

            /// <summary>
            /// If true, disable_mention_notifications is ignored and the value for the relevant type of chat or the forum chat is used instead
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_default_disable_mention_notifications")]
            public bool UseDefaultDisableMentionNotifications { get; set; }

            /// <summary>
            /// If true, notifications for messages with mentions will be created as for an ordinary unread message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("disable_mention_notifications")]
            public bool DisableMentionNotifications { get; set; }
        }
    }
}
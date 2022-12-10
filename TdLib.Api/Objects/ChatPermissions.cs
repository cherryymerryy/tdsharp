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
        /// Describes actions that a user is allowed to take in a chat
        /// </summary>
        public partial class ChatPermissions : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatPermissions";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if the user can send text messages, contacts, locations, and venues
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_send_messages")]
            public bool CanSendMessages { get; set; }

            /// <summary>
            /// True, if the user can send audio files, documents, photos, videos, video notes, and voice notes. Implies can_send_messages permissions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_send_media_messages")]
            public bool CanSendMediaMessages { get; set; }

            /// <summary>
            /// True, if the user can send polls. Implies can_send_messages permissions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_send_polls")]
            public bool CanSendPolls { get; set; }

            /// <summary>
            /// True, if the user can send animations, games, stickers, and dice and use inline bots. Implies can_send_messages permissions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_send_other_messages")]
            public bool CanSendOtherMessages { get; set; }

            /// <summary>
            /// True, if the user may add a web page preview to their messages. Implies can_send_messages permissions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_add_web_page_previews")]
            public bool CanAddWebPagePreviews { get; set; }

            /// <summary>
            /// True, if the user can change the chat title, photo, and other settings
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_change_info")]
            public bool CanChangeInfo { get; set; }

            /// <summary>
            /// True, if the user can invite new users to the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_invite_users")]
            public bool CanInviteUsers { get; set; }

            /// <summary>
            /// True, if the user can pin messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_pin_messages")]
            public bool CanPinMessages { get; set; }

            /// <summary>
            /// True, if the user can manage topics
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_manage_topics")]
            public bool CanManageTopics { get; set; }
        }
    }
}
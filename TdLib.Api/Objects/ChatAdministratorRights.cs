using System;
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
        /// Describes rights of the administrator
        /// </summary>
        public partial class ChatAdministratorRights : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatAdministratorRights";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if the administrator can access the chat event log, get boost list, see hidden supergroup and channel members, report supergroup spam messages and ignore slow mode. Implied by any other privilege; applicable to supergroups and channels only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_manage_chat")]
            public bool CanManageChat { get; set; }

            /// <summary>
            /// True, if the administrator can change the chat title, photo, and other settings
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_change_info")]
            public bool CanChangeInfo { get; set; }

            /// <summary>
            /// True, if the administrator can create channel posts or view channel statistics; applicable to channels only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_post_messages")]
            public bool CanPostMessages { get; set; }

            /// <summary>
            /// True, if the administrator can edit messages of other users and pin messages; applicable to channels only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_edit_messages")]
            public bool CanEditMessages { get; set; }

            /// <summary>
            /// True, if the administrator can delete messages of other users
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_delete_messages")]
            public bool CanDeleteMessages { get; set; }

            /// <summary>
            /// True, if the administrator can invite new users to the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_invite_users")]
            public bool CanInviteUsers { get; set; }

            /// <summary>
            /// True, if the administrator can restrict, ban, or unban chat members or view supergroup statistics; always true for channels
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_restrict_members")]
            public bool CanRestrictMembers { get; set; }

            /// <summary>
            /// True, if the administrator can pin messages; applicable to basic groups and supergroups only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_pin_messages")]
            public bool CanPinMessages { get; set; }

            /// <summary>
            /// True, if the administrator can create, rename, close, reopen, hide, and unhide forum topics; applicable to forum supergroups only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_manage_topics")]
            public bool CanManageTopics { get; set; }

            /// <summary>
            /// True, if the administrator can add new administrators with a subset of their own privileges or demote administrators that were directly or indirectly promoted by them
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_promote_members")]
            public bool CanPromoteMembers { get; set; }

            /// <summary>
            /// True, if the administrator can manage video chats
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_manage_video_chats")]
            public bool CanManageVideoChats { get; set; }

            /// <summary>
            /// True, if the administrator can create new chat stories, or edit and delete posted stories; applicable to supergroups and channels only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_post_stories")]
            public bool CanPostStories { get; set; }

            /// <summary>
            /// True, if the administrator can edit stories posted by other users, post stories to the chat page, pin chat stories, and access story archive; applicable to supergroups and channels only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_edit_stories")]
            public bool CanEditStories { get; set; }

            /// <summary>
            /// True, if the administrator can delete stories posted by other users; applicable to supergroups and channels only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_delete_stories")]
            public bool CanDeleteStories { get; set; }

            /// <summary>
            /// True, if the administrator isn't shown in the chat member list and sends messages anonymously; applicable to supergroups only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_anonymous")]
            public bool IsAnonymous { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
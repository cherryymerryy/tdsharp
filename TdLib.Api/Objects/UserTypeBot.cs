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
        public partial class UserType : Object
        {
            /// <summary>
            /// A bot (see https://core.telegram.org/bots)
            /// </summary>
            public class UserTypeBot : UserType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userTypeBot";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// True, if the bot is owned by the current user and can be edited using the methods toggleBotUsernameIsActive, reorderBotActiveUsernames, setBotProfilePhoto, setBotName, setBotInfoDescription, and setBotInfoShortDescription
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_be_edited")]
                public bool CanBeEdited { get; set; }

                /// <summary>
                /// True, if the bot can be invited to basic group and supergroup chats
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_join_groups")]
                public bool CanJoinGroups { get; set; }

                /// <summary>
                /// True, if the bot can read all messages in basic group or supergroup chats and not just those addressed to the bot. In private and channel chats a bot can always read all messages
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_read_all_group_messages")]
                public bool CanReadAllGroupMessages { get; set; }

                /// <summary>
                /// True, if the bot supports inline queries
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_inline")]
                public bool IsInline { get; set; }

                /// <summary>
                /// Placeholder for inline queries (displayed on the application input field)
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("inline_query_placeholder")]
                public string InlineQueryPlaceholder { get; set; }

                /// <summary>
                /// True, if the location of the user is expected to be sent with every inline query to this bot
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("need_location")]
                public bool NeedLocation { get; set; }

                /// <summary>
                /// True, if the bot supports connection to Telegram Business accounts
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_connect_to_business")]
                public bool CanConnectToBusiness { get; set; }

                /// <summary>
                /// True, if the bot can be added to attachment or side menu
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_be_added_to_attachment_menu")]
                public bool CanBeAddedToAttachmentMenu { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
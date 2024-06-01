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
        /// Contains privacy settings for new chats with non-contacts
        /// </summary>
        public partial class NewChatPrivacySettings : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "newChatPrivacySettings";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if non-contacts users are able to write first to the current user. Telegram Premium subscribers are able to write first regardless of this setting
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("allow_new_chats_from_unknown_users")]
            public bool AllowNewChatsFromUnknownUsers { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
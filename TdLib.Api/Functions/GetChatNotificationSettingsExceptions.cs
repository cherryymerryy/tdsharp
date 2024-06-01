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
        /// Returns the list of chats with non-default notification settings for new messages
        /// </summary>
        public class GetChatNotificationSettingsExceptions : Function<Chats>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatNotificationSettingsExceptions";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// If specified, only chats from the scope will be returned; pass null to return chats from all scopes
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("scope")]
            public NotificationSettingsScope Scope { get; set; }

            /// <summary>
            /// Pass true to include in the response chats with only non-default sound
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("compare_sound")]
            public bool CompareSound { get; set; }
        }

        /// <summary>
        /// Returns the list of chats with non-default notification settings for new messages
        /// </summary>
        public static Task<Chats> GetChatNotificationSettingsExceptionsAsync(
            this Client client, NotificationSettingsScope scope = default, bool compareSound = default)
        {
            return client.ExecuteAsync(new GetChatNotificationSettingsExceptions
            {
                Scope = scope, CompareSound = compareSound
            });
        }
    }
}
// REUSE-IgnoreEnd
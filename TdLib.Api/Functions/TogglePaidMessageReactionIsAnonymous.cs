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
        /// Changes whether the paid message reaction of the user to a message is anonymous. The message must have paid reaction added by the user
        /// </summary>
        public class TogglePaidMessageReactionIsAnonymous : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "togglePaidMessageReactionIsAnonymous";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which the message belongs
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// Pass true to make paid reaction of the user on the message anonymous; pass false to make the user's profile visible among top reactors
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_anonymous")]
            public bool IsAnonymous { get; set; }
        }

        /// <summary>
        /// Changes whether the paid message reaction of the user to a message is anonymous. The message must have paid reaction added by the user
        /// </summary>
        public static Task<Ok> TogglePaidMessageReactionIsAnonymousAsync(
            this Client client, long chatId = default, long messageId = default, bool isAnonymous = default)
        {
            return client.ExecuteAsync(new TogglePaidMessageReactionIsAnonymous
            {
                ChatId = chatId, MessageId = messageId, IsAnonymous = isAnonymous
            });
        }
    }
}
// REUSE-IgnoreEnd
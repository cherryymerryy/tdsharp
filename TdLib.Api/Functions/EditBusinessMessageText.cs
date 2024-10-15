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
        /// Edits the text of a text or game message sent on behalf of a business account; for bots only
        /// </summary>
        public class EditBusinessMessageText : Function<BusinessMessage>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editBusinessMessageText";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of business connection on behalf of which the message was sent
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("business_connection_id")]
            public string BusinessConnectionId { get; set; }

            /// <summary>
            /// The chat the message belongs to
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
            /// The new message reply markup; pass null if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }

            /// <summary>
            /// New text content of the message. Must be of type inputMessageText
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("input_message_content")]
            public InputMessageContent InputMessageContent { get; set; }
        }

        /// <summary>
        /// Edits the text of a text or game message sent on behalf of a business account; for bots only
        /// </summary>
        public static Task<BusinessMessage> EditBusinessMessageTextAsync(
            this Client client, string businessConnectionId = default, long chatId = default, long messageId = default, ReplyMarkup replyMarkup = default, InputMessageContent inputMessageContent = default)
        {
            return client.ExecuteAsync(new EditBusinessMessageText
            {
                BusinessConnectionId = businessConnectionId, ChatId = chatId, MessageId = messageId, ReplyMarkup = replyMarkup, InputMessageContent = inputMessageContent
            });
        }
    }
}
// REUSE-IgnoreEnd
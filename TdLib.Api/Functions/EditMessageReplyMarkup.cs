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
        /// Edits the message reply markup; for bots only. Returns the edited message after the edit is completed on the server side
        /// </summary>
        public class EditMessageReplyMarkup : Function<Message>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editMessageReplyMarkup";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

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
        }

        /// <summary>
        /// Edits the message reply markup; for bots only. Returns the edited message after the edit is completed on the server side
        /// </summary>
        public static Task<Message> EditMessageReplyMarkupAsync(
            this Client client, long chatId = default, long messageId = default, ReplyMarkup replyMarkup = default)
        {
            return client.ExecuteAsync(new EditMessageReplyMarkup
            {
                ChatId = chatId, MessageId = messageId, ReplyMarkup = replyMarkup
            });
        }
    }
}
// REUSE-IgnoreEnd
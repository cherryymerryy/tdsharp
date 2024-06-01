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
        /// Stops a poll. A poll in a message can be stopped when the message has can_be_edited flag is set
        /// </summary>
        public class StopPoll : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "stopPoll";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which the poll belongs
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message containing the poll
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// The new message reply markup; pass null if none; for bots only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }
        }

        /// <summary>
        /// Stops a poll. A poll in a message can be stopped when the message has can_be_edited flag is set
        /// </summary>
        public static Task<Ok> StopPollAsync(
            this Client client, long chatId = default, long messageId = default, ReplyMarkup replyMarkup = default)
        {
            return client.ExecuteAsync(new StopPoll
            {
                ChatId = chatId, MessageId = messageId, ReplyMarkup = replyMarkup
            });
        }
    }
}
// REUSE-IgnoreEnd
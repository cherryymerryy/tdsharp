using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Sends a message. Returns the sent message
        /// </summary>
        public class SendMessage : Function<Message>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Target chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// If not 0, a message thread identifier in which the message will be sent
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_thread_id")]
            public long MessageThreadId { get; set; }

            /// <summary>
            /// Information about the message or story to be replied; pass null if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_to")]
            public InputMessageReplyTo ReplyTo { get; set; }

            /// <summary>
            /// Options to be used to send the message; pass null to use default options
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("options")]
            public MessageSendOptions Options { get; set; }

            /// <summary>
            /// Markup for replying to the message; pass null if none; for bots only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }

            /// <summary>
            /// The content of the message to be sent
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("input_message_content")]
            public InputMessageContent InputMessageContent { get; set; }
        }

        /// <summary>
        /// Sends a message. Returns the sent message
        /// </summary>
        public static Task<Message> SendMessageAsync(
            this Client client, long chatId = default, long messageThreadId = default, InputMessageReplyTo replyTo = default, MessageSendOptions options = default, ReplyMarkup replyMarkup = default, InputMessageContent inputMessageContent = default)
        {
            return client.ExecuteAsync(new SendMessage
            {
                ChatId = chatId, MessageThreadId = messageThreadId, ReplyTo = replyTo, Options = options, ReplyMarkup = replyMarkup, InputMessageContent = inputMessageContent
            });
        }
    }
}
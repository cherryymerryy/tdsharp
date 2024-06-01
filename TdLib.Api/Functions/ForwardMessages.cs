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
        /// Forwards previously sent messages. Returns the forwarded messages in the same order as the message identifiers passed in message_ids. If a message can't be forwarded, null will be returned instead of the message
        /// </summary>
        public class ForwardMessages : Function<Messages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "forwardMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which to forward messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// If not 0, the message thread identifier in which the message will be sent; for forum threads only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_thread_id")]
            public long MessageThreadId { get; set; }

            /// <summary>
            /// Identifier of the chat from which to forward messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("from_chat_id")]
            public long FromChatId { get; set; }

            /// <summary>
            /// Identifiers of the messages to forward. Message identifiers must be in a strictly increasing order. At most 100 messages can be forwarded simultaneously. A message can be forwarded only if message.can_be_forwarded
            /// </summary>
            [JsonProperty("message_ids", ItemConverterType = typeof(Converter))]
            public long[] MessageIds { get; set; }

            /// <summary>
            /// Options to be used to send the messages; pass null to use default options
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("options")]
            public MessageSendOptions Options { get; set; }

            /// <summary>
            /// Pass true to copy content of the messages without reference to the original sender. Always true if the messages are forwarded to a secret chat or are local
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("send_copy")]
            public bool SendCopy { get; set; }

            /// <summary>
            /// Pass true to remove media captions of message copies. Ignored if send_copy is false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("remove_caption")]
            public bool RemoveCaption { get; set; }
        }

        /// <summary>
        /// Forwards previously sent messages. Returns the forwarded messages in the same order as the message identifiers passed in message_ids. If a message can't be forwarded, null will be returned instead of the message
        /// </summary>
        public static Task<Messages> ForwardMessagesAsync(
            this Client client, long chatId = default, long messageThreadId = default, long fromChatId = default, long[] messageIds = default, MessageSendOptions options = default, bool sendCopy = default, bool removeCaption = default)
        {
            return client.ExecuteAsync(new ForwardMessages
            {
                ChatId = chatId, MessageThreadId = messageThreadId, FromChatId = fromChatId, MessageIds = messageIds, Options = options, SendCopy = sendCopy, RemoveCaption = removeCaption
            });
        }
    }
}
// REUSE-IgnoreEnd
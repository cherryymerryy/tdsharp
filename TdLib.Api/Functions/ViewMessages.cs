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
        /// Informs TDLib that messages are being viewed by the user. Sponsored messages must be marked as viewed only when the entire text of the message is shown on the screen (excluding the button). Many useful activities depend on whether the messages are currently being viewed or not (e.g., marking messages as read, incrementing a view counter, updating a view counter, removing deleted messages in supergroups and channels)
        /// </summary>
        public class ViewMessages : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "viewMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// If not 0, a message thread identifier in which the messages are being viewed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_thread_id")]
            public long MessageThreadId { get; set; }

            /// <summary>
            /// The identifiers of the messages being viewed
            /// </summary>
            [JsonProperty("message_ids", ItemConverterType = typeof(Converter))]
            public long[] MessageIds { get; set; }

            /// <summary>
            /// True, if messages in closed chats must be marked as read by the request
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("force_read")]
            public bool ForceRead { get; set; }
        }

        /// <summary>
        /// Informs TDLib that messages are being viewed by the user. Sponsored messages must be marked as viewed only when the entire text of the message is shown on the screen (excluding the button). Many useful activities depend on whether the messages are currently being viewed or not (e.g., marking messages as read, incrementing a view counter, updating a view counter, removing deleted messages in supergroups and channels)
        /// </summary>
        public static Task<Ok> ViewMessagesAsync(
            this Client client, long chatId = default, long messageThreadId = default, long[] messageIds = default, bool forceRead = default)
        {
            return client.ExecuteAsync(new ViewMessages
            {
                ChatId = chatId, MessageThreadId = messageThreadId, MessageIds = messageIds, ForceRead = forceRead
            });
        }
    }
}
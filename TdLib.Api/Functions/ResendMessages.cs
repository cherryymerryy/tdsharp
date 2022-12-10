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
        /// Resends messages which failed to send. Can be called only for messages for which messageSendingStateFailed.can_retry is true and after specified in messageSendingStateFailed.retry_after time passed.
        /// </summary>
        public class ResendMessages : Function<Messages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resendMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to send messages
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifiers of the messages to resend. Message identifiers must be in a strictly increasing order
            /// </summary>
            [JsonProperty("message_ids", ItemConverterType = typeof(Converter))]
            public long[] MessageIds { get; set; }
        }

        /// <summary>
        /// Resends messages which failed to send. Can be called only for messages for which messageSendingStateFailed.can_retry is true and after specified in messageSendingStateFailed.retry_after time passed.
        /// </summary>
        public static Task<Messages> ResendMessagesAsync(
            this Client client, long chatId = default, long[] messageIds = default)
        {
            return client.ExecuteAsync(new ResendMessages
            {
                ChatId = chatId, MessageIds = messageIds
            });
        }
    }
}
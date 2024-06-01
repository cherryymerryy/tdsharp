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
        /// Reports reactions set on a message to the Telegram moderators. Reactions on a message can be reported only if message.can_report_reactions
        /// </summary>
        public class ReportMessageReactions : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "reportMessageReactions";

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
            /// Message identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// Identifier of the sender, which added the reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sender_id")]
            public MessageSender SenderId { get; set; }
        }

        /// <summary>
        /// Reports reactions set on a message to the Telegram moderators. Reactions on a message can be reported only if message.can_report_reactions
        /// </summary>
        public static Task<Ok> ReportMessageReactionsAsync(
            this Client client, long chatId = default, long messageId = default, MessageSender senderId = default)
        {
            return client.ExecuteAsync(new ReportMessageReactions
            {
                ChatId = chatId, MessageId = messageId, SenderId = senderId
            });
        }
    }
}
// REUSE-IgnoreEnd
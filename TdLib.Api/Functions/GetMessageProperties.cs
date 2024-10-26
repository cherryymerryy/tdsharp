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
        /// Returns properties of a message; this is an offline request
        /// </summary>
        public class GetMessageProperties : Function<MessageProperties>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMessageProperties";

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
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }
        }

        /// <summary>
        /// Returns properties of a message; this is an offline request
        /// </summary>
        public static Task<MessageProperties> GetMessagePropertiesAsync(
            this Client client, long chatId = default, long messageId = default)
        {
            return client.ExecuteAsync(new GetMessageProperties
            {
                ChatId = chatId, MessageId = messageId
            });
        }
    }
}
// REUSE-IgnoreEnd
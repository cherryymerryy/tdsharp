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
        /// Informs TDLib that the user opened the sponsored chat via the button, the name, the photo, or a mention in the sponsored message
        /// </summary>
        public class ClickChatSponsoredMessage : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "clickChatSponsoredMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier of the sponsored message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the sponsored message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }
        }

        /// <summary>
        /// Informs TDLib that the user opened the sponsored chat via the button, the name, the photo, or a mention in the sponsored message
        /// </summary>
        public static Task<Ok> ClickChatSponsoredMessageAsync(
            this Client client, long chatId = default, long messageId = default)
        {
            return client.ExecuteAsync(new ClickChatSponsoredMessage
            {
                ChatId = chatId, MessageId = messageId
            });
        }
    }
}
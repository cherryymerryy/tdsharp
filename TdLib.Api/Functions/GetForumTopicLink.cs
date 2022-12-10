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
        /// Returns an HTTPS link to a topic in a forum chat. This is an offline request
        /// </summary>
        public class GetForumTopicLink : Function<HttpUrl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getForumTopicLink";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Message thread identifier of the forum topic
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_thread_id")]
            public long MessageThreadId { get; set; }
        }

        /// <summary>
        /// Returns an HTTPS link to a topic in a forum chat. This is an offline request
        /// </summary>
        public static Task<HttpUrl> GetForumTopicLinkAsync(
            this Client client, long chatId = default, long messageThreadId = default)
        {
            return client.ExecuteAsync(new GetForumTopicLink
            {
                ChatId = chatId, MessageThreadId = messageThreadId
            });
        }
    }
}
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
        /// Returns affiliate programs that were connected to the given chat
        /// </summary>
        public class GetChatAffiliatePrograms : Function<ChatAffiliatePrograms>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatAffiliatePrograms";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat for which the affiliate programs were connected. Can be an identifier of the Saved Messages chat, of a chat with an owned bot, or of a channel chat with can_post_messages administrator right
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Offset of the first affiliate program to return as received from the previous request; use empty string to get the first chunk of results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public string Offset { get; set; }

            /// <summary>
            /// The maximum number of affiliate programs to return
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns affiliate programs that were connected to the given chat
        /// </summary>
        public static Task<ChatAffiliatePrograms> GetChatAffiliateProgramsAsync(
            this Client client, long chatId = default, string offset = default, int limit = default)
        {
            return client.ExecuteAsync(new GetChatAffiliatePrograms
            {
                ChatId = chatId, Offset = offset, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd
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
        /// Returns information about the recent locations of chat members that were sent to the chat. Returns up to 1 location message per user
        /// </summary>
        public class SearchChatRecentLocationMessages : Function<Messages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchChatRecentLocationMessages";

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
            /// The maximum number of messages to be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns information about the recent locations of chat members that were sent to the chat. Returns up to 1 location message per user
        /// </summary>
        public static Task<Messages> SearchChatRecentLocationMessagesAsync(
            this Client client, long chatId = default, int limit = default)
        {
            return client.ExecuteAsync(new SearchChatRecentLocationMessages
            {
                ChatId = chatId, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd
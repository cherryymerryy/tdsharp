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
        /// Searches affiliate programs that can be applied to the given chat
        /// </summary>
        public class SearchAffiliatePrograms : Function<FoundAffiliatePrograms>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchAffiliatePrograms";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat for which affiliate programs are searched for. Can be an identifier of the Saved Messages chat, of a chat with an owned bot, or of a channel chat with can_post_messages administrator right
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Sort order for the results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sort_order")]
            public AffiliateProgramSortOrder SortOrder { get; set; }

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
        /// Searches affiliate programs that can be applied to the given chat
        /// </summary>
        public static Task<FoundAffiliatePrograms> SearchAffiliateProgramsAsync(
            this Client client, long chatId = default, AffiliateProgramSortOrder sortOrder = default, string offset = default, int limit = default)
        {
            return client.ExecuteAsync(new SearchAffiliatePrograms
            {
                ChatId = chatId, SortOrder = sortOrder, Offset = offset, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd
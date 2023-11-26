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
        /// Sends an inline query to a bot and returns its results. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        public class GetInlineQueryResults : Function<InlineQueryResults>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getInlineQueryResults";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the target bot
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public long BotUserId { get; set; }

            /// <summary>
            /// Identifier of the chat where the query was sent
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Location of the user; pass null if unknown or the bot doesn't need user's location
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_location")]
            public Location UserLocation { get; set; }

            /// <summary>
            /// Text of the query
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("query")]
            public string Query { get; set; }

            /// <summary>
            /// Offset of the first entry to return; use empty string to get the first chunk of results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public string Offset { get; set; }
        }

        /// <summary>
        /// Sends an inline query to a bot and returns its results. Returns an error with code 502 if the bot fails to answer the query before the query timeout expires
        /// </summary>
        public static Task<InlineQueryResults> GetInlineQueryResultsAsync(
            this Client client, long botUserId = default, long chatId = default, Location userLocation = default, string query = default, string offset = default)
        {
            return client.ExecuteAsync(new GetInlineQueryResults
            {
                BotUserId = botUserId, ChatId = chatId, UserLocation = userLocation, Query = query, Offset = offset
            });
        }
    }
}
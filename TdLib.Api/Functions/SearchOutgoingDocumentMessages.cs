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
        /// Searches for outgoing messages with content of the type messageDocument in all chats except secret chats. Returns the results in reverse chronological order
        /// </summary>
        public class SearchOutgoingDocumentMessages : Function<FoundMessages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchOutgoingDocumentMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Query to search for in document file name and message caption
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("query")]
            public string Query { get; set; }

            /// <summary>
            /// The maximum number of messages to be returned; up to 100
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Searches for outgoing messages with content of the type messageDocument in all chats except secret chats. Returns the results in reverse chronological order
        /// </summary>
        public static Task<FoundMessages> SearchOutgoingDocumentMessagesAsync(
            this Client client, string query = default, int limit = default)
        {
            return client.ExecuteAsync(new SearchOutgoingDocumentMessages
            {
                Query = query, Limit = limit
            });
        }
    }
}
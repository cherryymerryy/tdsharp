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
        /// Returns a list of frequently used chats
        /// </summary>
        public class GetTopChats : Function<Chats>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getTopChats";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Category of chats to be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("category")]
            public TopChatCategory Category { get; set; }

            /// <summary>
            /// The maximum number of chats to be returned; up to 30
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns a list of frequently used chats
        /// </summary>
        public static Task<Chats> GetTopChatsAsync(
            this Client client, TopChatCategory category = default, int limit = default)
        {
            return client.ExecuteAsync(new GetTopChats
            {
                Category = category, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd
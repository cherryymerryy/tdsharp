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
        /// Returns the list of Telegram Star transactions for the specified owner
        /// </summary>
        public class GetStarTransactions : Function<StarTransactions>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getStarTransactions";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the owner of the Telegram Stars; can be the identifier of the current user, identifier of an owned bot,
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("owner_id")]
            public MessageSender OwnerId { get; set; }

            /// <summary>
            /// If non-empty, only transactions related to the Star Subscription will be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("subscription_id")]
            public string SubscriptionId { get; set; }

            /// <summary>
            /// Direction of the transactions to receive; pass null to get all transactions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("direction")]
            public StarTransactionDirection Direction { get; set; }

            /// <summary>
            /// Offset of the first transaction to return as received from the previous request; use empty string to get the first chunk of results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public string Offset { get; set; }

            /// <summary>
            /// The maximum number of transactions to return
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns the list of Telegram Star transactions for the specified owner
        /// </summary>
        public static Task<StarTransactions> GetStarTransactionsAsync(
            this Client client, MessageSender ownerId = default, string subscriptionId = default, StarTransactionDirection direction = default, string offset = default, int limit = default)
        {
            return client.ExecuteAsync(new GetStarTransactions
            {
                OwnerId = ownerId, SubscriptionId = subscriptionId, Direction = direction, Offset = offset, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd
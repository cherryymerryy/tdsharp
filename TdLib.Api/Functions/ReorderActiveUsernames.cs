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
        /// Changes order of active usernames of the current user
        /// </summary>
        public class ReorderActiveUsernames : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "reorderActiveUsernames";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new order of active usernames. All currently active usernames must be specified
            /// </summary>
            [JsonProperty("usernames", ItemConverterType = typeof(Converter))]
            public string[] Usernames { get; set; }
        }

        /// <summary>
        /// Changes order of active usernames of the current user
        /// </summary>
        public static Task<Ok> ReorderActiveUsernamesAsync(
            this Client client, string[] usernames = default)
        {
            return client.ExecuteAsync(new ReorderActiveUsernames
            {
                Usernames = usernames
            });
        }
    }
}
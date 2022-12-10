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
        /// Searches a user by a token from the user's link
        /// </summary>
        public class SearchUserByToken : Function<User>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchUserByToken";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Token to search for
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("token")]
            public string Token { get; set; }
        }

        /// <summary>
        /// Searches a user by a token from the user's link
        /// </summary>
        public static Task<User> SearchUserByTokenAsync(
            this Client client, string token = default)
        {
            return client.ExecuteAsync(new SearchUserByToken
            {
                Token = token
            });
        }
    }
}
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
        /// Returns all close friends of the current user
        /// </summary>
        public class GetCloseFriends : Function<Users>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getCloseFriends";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns all close friends of the current user
        /// </summary>
        public static Task<Users> GetCloseFriendsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetCloseFriends
            {
                
            });
        }
    }
}
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
        /// Returns all active sessions of the current user
        /// </summary>
        public class GetActiveSessions : Function<Sessions>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getActiveSessions";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns all active sessions of the current user
        /// </summary>
        public static Task<Sessions> GetActiveSessionsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetActiveSessions
            {
                
            });
        }
    }
}
// REUSE-IgnoreEnd
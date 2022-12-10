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
        /// Clears the list of recently used emoji statuses
        /// </summary>
        public class ClearRecentEmojiStatuses : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "clearRecentEmojiStatuses";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Clears the list of recently used emoji statuses
        /// </summary>
        public static Task<Ok> ClearRecentEmojiStatusesAsync(
            this Client client)
        {
            return client.ExecuteAsync(new ClearRecentEmojiStatuses
            {
                
            });
        }
    }
}
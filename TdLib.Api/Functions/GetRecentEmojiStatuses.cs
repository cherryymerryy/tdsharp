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
        /// Returns recent emoji statuses
        /// </summary>
        public class GetRecentEmojiStatuses : Function<EmojiStatuses>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getRecentEmojiStatuses";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns recent emoji statuses
        /// </summary>
        public static Task<EmojiStatuses> GetRecentEmojiStatusesAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetRecentEmojiStatuses
            {
                
            });
        }
    }
}
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
        /// Returns information about a link to boost a chat. Can be called for any internal link of the type internalLinkTypeChatBoost
        /// </summary>
        public class GetChatBoostLinkInfo : Function<ChatBoostLinkInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatBoostLinkInfo";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The link to boost a chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }
        }

        /// <summary>
        /// Returns information about a link to boost a chat. Can be called for any internal link of the type internalLinkTypeChatBoost
        /// </summary>
        public static Task<ChatBoostLinkInfo> GetChatBoostLinkInfoAsync(
            this Client client, string url = default)
        {
            return client.ExecuteAsync(new GetChatBoostLinkInfo
            {
                Url = url
            });
        }
    }
}
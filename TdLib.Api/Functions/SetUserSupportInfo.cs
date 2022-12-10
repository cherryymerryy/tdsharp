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
        /// Sets support information for the given user; for Telegram support only
        /// </summary>
        public class SetUserSupportInfo : Function<UserSupportInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setUserSupportInfo";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// User identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// New information message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message")]
            public FormattedText Message { get; set; }
        }

        /// <summary>
        /// Sets support information for the given user; for Telegram support only
        /// </summary>
        public static Task<UserSupportInfo> SetUserSupportInfoAsync(
            this Client client, long userId = default, FormattedText message = default)
        {
            return client.ExecuteAsync(new SetUserSupportInfo
            {
                UserId = userId, Message = message
            });
        }
    }
}
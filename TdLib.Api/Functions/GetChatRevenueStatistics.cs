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
        /// Returns detailed revenue statistics about a chat. Currently, this method can be used only
        /// for channels if supergroupFullInfo.can_get_revenue_statistics == true or bots if userFullInfo.bot_info.can_get_revenue_statistics == true
        /// </summary>
        public class GetChatRevenueStatistics : Function<ChatRevenueStatistics>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatRevenueStatistics";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Pass true if a dark theme is used by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_dark")]
            public bool IsDark { get; set; }
        }

        /// <summary>
        /// Returns detailed revenue statistics about a chat. Currently, this method can be used only
        /// for channels if supergroupFullInfo.can_get_revenue_statistics == true or bots if userFullInfo.bot_info.can_get_revenue_statistics == true
        /// </summary>
        public static Task<ChatRevenueStatistics> GetChatRevenueStatisticsAsync(
            this Client client, long chatId = default, bool isDark = default)
        {
            return client.ExecuteAsync(new GetChatRevenueStatistics
            {
                ChatId = chatId, IsDark = isDark
            });
        }
    }
}
// REUSE-IgnoreEnd
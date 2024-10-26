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
        /// Delete media previews from the list of media previews of a bot
        /// </summary>
        public class DeleteBotMediaPreviews : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deleteBotMediaPreviews";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the target bot. The bot must be owned and must have the main Web App
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public long BotUserId { get; set; }

            /// <summary>
            /// Language code of the media previews to delete
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("language_code")]
            public string LanguageCode { get; set; }

            /// <summary>
            /// File identifiers of the media to delete
            /// </summary>
            [JsonProperty("file_ids", ItemConverterType = typeof(Converter))]
            public int[] FileIds { get; set; }
        }

        /// <summary>
        /// Delete media previews from the list of media previews of a bot
        /// </summary>
        public static Task<Ok> DeleteBotMediaPreviewsAsync(
            this Client client, long botUserId = default, string languageCode = default, int[] fileIds = default)
        {
            return client.ExecuteAsync(new DeleteBotMediaPreviews
            {
                BotUserId = botUserId, LanguageCode = languageCode, FileIds = fileIds
            });
        }
    }
}
// REUSE-IgnoreEnd
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
        /// Returns an HTTPS URL of a Web App to open from the side menu, a keyboardButtonTypeWebApp button, an inlineQueryResultsButtonTypeWebApp button, or an internalLinkTypeSideMenuBot link
        /// </summary>
        public class GetWebAppUrl : Function<HttpUrl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getWebAppUrl";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the target bot
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public long BotUserId { get; set; }

            /// <summary>
            /// The URL from a keyboardButtonTypeWebApp button, inlineQueryResultsButtonTypeWebApp button, an internalLinkTypeSideMenuBot link, or an empty when the bot is opened from the side menu
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// Preferred Web App theme; pass null to use the default theme
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("theme")]
            public ThemeParameters Theme { get; set; }

            /// <summary>
            /// Short name of the application; 0-64 English letters, digits, and underscores
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("application_name")]
            public string ApplicationName { get; set; }
        }

        /// <summary>
        /// Returns an HTTPS URL of a Web App to open from the side menu, a keyboardButtonTypeWebApp button, an inlineQueryResultsButtonTypeWebApp button, or an internalLinkTypeSideMenuBot link
        /// </summary>
        public static Task<HttpUrl> GetWebAppUrlAsync(
            this Client client, long botUserId = default, string url = default, ThemeParameters theme = default, string applicationName = default)
        {
            return client.ExecuteAsync(new GetWebAppUrl
            {
                BotUserId = botUserId, Url = url, Theme = theme, ApplicationName = applicationName
            });
        }
    }
}
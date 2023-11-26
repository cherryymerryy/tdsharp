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
        /// Parses Bold, Italic, Underline, Strikethrough, Spoiler, CustomEmoji, BlockQuote, Code, Pre, PreCode, TextUrl and MentionName entities from a marked-up text. Can be called synchronously
        /// </summary>
        public class ParseTextEntities : Function<FormattedText>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "parseTextEntities";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The text to parse
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public string Text { get; set; }

            /// <summary>
            /// Text parse mode
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("parse_mode")]
            public TextParseMode ParseMode { get; set; }
        }

        /// <summary>
        /// Parses Bold, Italic, Underline, Strikethrough, Spoiler, CustomEmoji, BlockQuote, Code, Pre, PreCode, TextUrl and MentionName entities from a marked-up text. Can be called synchronously
        /// </summary>
        public static Task<FormattedText> ParseTextEntitiesAsync(
            this Client client, string text = default, TextParseMode parseMode = default)
        {
            return client.ExecuteAsync(new ParseTextEntities
            {
                Text = text, ParseMode = parseMode
            });
        }
    }
}
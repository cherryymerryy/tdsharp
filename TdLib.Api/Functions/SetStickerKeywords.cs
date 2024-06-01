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
        /// Changes the list of keywords of a sticker. The sticker must belong to a regular or custom emoji sticker set that is owned by the current user
        /// </summary>
        public class SetStickerKeywords : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setStickerKeywords";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Sticker
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public InputFile Sticker { get; set; }

            /// <summary>
            /// List of up to 20 keywords with total length up to 64 characters, which can be used to find the sticker
            /// </summary>
            [JsonProperty("keywords", ItemConverterType = typeof(Converter))]
            public string[] Keywords { get; set; }
        }

        /// <summary>
        /// Changes the list of keywords of a sticker. The sticker must belong to a regular or custom emoji sticker set that is owned by the current user
        /// </summary>
        public static Task<Ok> SetStickerKeywordsAsync(
            this Client client, InputFile sticker = default, string[] keywords = default)
        {
            return client.ExecuteAsync(new SetStickerKeywords
            {
                Sticker = sticker, Keywords = keywords
            });
        }
    }
}
// REUSE-IgnoreEnd
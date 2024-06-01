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
        /// Searches for stickers from public sticker sets that correspond to any of the given emoji
        /// </summary>
        public class SearchStickers : Function<Stickers>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchStickers";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Type of the stickers to return
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker_type")]
            public StickerType StickerType { get; set; }

            /// <summary>
            /// Space-separated list of emoji to search for; must be non-empty
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("emojis")]
            public string Emojis { get; set; }

            /// <summary>
            /// The maximum number of stickers to be returned; 0-100
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Searches for stickers from public sticker sets that correspond to any of the given emoji
        /// </summary>
        public static Task<Stickers> SearchStickersAsync(
            this Client client, StickerType stickerType = default, string emojis = default, int limit = default)
        {
            return client.ExecuteAsync(new SearchStickers
            {
                StickerType = stickerType, Emojis = emojis, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd
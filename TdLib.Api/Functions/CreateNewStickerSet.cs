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
        /// Creates a new sticker set. Returns the newly created sticker set
        /// </summary>
        public class CreateNewStickerSet : Function<StickerSet>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "createNewStickerSet";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Sticker set owner; ignored for regular users
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// Sticker set title; 1-64 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Sticker set name. Can contain only English letters, digits and underscores. Must end with *"_by_<bot username>"* (*<bot_username>* is case insensitive) for bots; 1-64 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// List of stickers to be added to the set; must be non-empty. All stickers must have the same format. For TGS stickers, uploadStickerFile must be used before the sticker is shown
            /// </summary>
            [JsonProperty("stickers", ItemConverterType = typeof(Converter))]
            public InputSticker[] Stickers { get; set; }

            /// <summary>
            /// Source of the sticker set; may be empty if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("source")]
            public string Source { get; set; }
        }

        /// <summary>
        /// Creates a new sticker set. Returns the newly created sticker set
        /// </summary>
        public static Task<StickerSet> CreateNewStickerSetAsync(
            this Client client, long userId = default, string title = default, string name = default, InputSticker[] stickers = default, string source = default)
        {
            return client.ExecuteAsync(new CreateNewStickerSet
            {
                UserId = userId, Title = title, Name = name, Stickers = stickers, Source = source
            });
        }
    }
}
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
        /// Returns default list of custom emoji stickers for placing on a profile photo
        /// </summary>
        public class GetDefaultProfilePhotoCustomEmojiStickers : Function<Stickers>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getDefaultProfilePhotoCustomEmojiStickers";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns default list of custom emoji stickers for placing on a profile photo
        /// </summary>
        public static Task<Stickers> GetDefaultProfilePhotoCustomEmojiStickersAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetDefaultProfilePhotoCustomEmojiStickers
            {
                
            });
        }
    }
}
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
        /// Returns TGS stickers with generic animations for custom emoji reactions
        /// </summary>
        public class GetCustomEmojiReactionAnimations : Function<Stickers>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getCustomEmojiReactionAnimations";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns TGS stickers with generic animations for custom emoji reactions
        /// </summary>
        public static Task<Stickers> GetCustomEmojiReactionAnimationsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetCustomEmojiReactionAnimations
            {
                
            });
        }
    }
}
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
        /// Returns examples of premium stickers for demonstration purposes
        /// </summary>
        public class GetPremiumStickerExamples : Function<Stickers>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getPremiumStickerExamples";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Returns examples of premium stickers for demonstration purposes
        /// </summary>
        public static Task<Stickers> GetPremiumStickerExamplesAsync(
            this Client client)
        {
            return client.ExecuteAsync(new GetPremiumStickerExamples
            {
                
            });
        }
    }
}
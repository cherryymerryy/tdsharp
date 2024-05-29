using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputStoryContent : Object
        {
            /// <summary>
            /// The content of a story to send
            /// </summary>
            public class InputStoryContentPhoto : InputStoryContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputStoryContentPhoto";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Photo to send. The photo must be at most 10 MB in size. The photo size must be 1080x1920
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public InputFile Photo { get; set; }

                /// <summary>
                /// File identifiers of the stickers added to the photo, if applicable
                /// </summary>
                [JsonProperty("added_sticker_file_ids", ItemConverterType = typeof(Converter))]
                public int[] AddedStickerFileIds { get; set; }
            }
        }
    }
}
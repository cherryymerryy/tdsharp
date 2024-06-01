using System;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InputMessageContent : Object
        {
            /// <summary>
            /// An animation message (GIF-style).
            /// </summary>
            public class InputMessageAnimation : InputMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessageAnimation";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Animation file to be sent
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("animation")]
                public InputFile Animation { get; set; }

                /// <summary>
                /// Animation thumbnail; pass null to skip thumbnail uploading
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public InputThumbnail Thumbnail { get; set; }

                /// <summary>
                /// File identifiers of the stickers added to the animation, if applicable
                /// </summary>
                [JsonProperty("added_sticker_file_ids", ItemConverterType = typeof(Converter))]
                public int[] AddedStickerFileIds { get; set; }

                /// <summary>
                /// Duration of the animation, in seconds
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int Duration { get; set; }

                /// <summary>
                /// Width of the animation; may be replaced by the server
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("width")]
                public int Width { get; set; }

                /// <summary>
                /// Height of the animation; may be replaced by the server
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("height")]
                public int Height { get; set; }

                /// <summary>
                /// Animation caption; pass null to use an empty caption; 0-getOption("message_caption_length_max") characters
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText Caption { get; set; }

                /// <summary>
                /// True, if the animation preview must be covered by a spoiler animation; not supported in secret chats
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("has_spoiler")]
                public bool HasSpoiler { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
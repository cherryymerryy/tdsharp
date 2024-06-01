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
            /// A photo message
            /// </summary>
            public class InputMessagePhoto : InputMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessagePhoto";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Photo to send. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public InputFile Photo { get; set; }

                /// <summary>
                /// Photo thumbnail to be sent; pass null to skip thumbnail uploading. The thumbnail is sent to the other party only in secret chats
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public InputThumbnail Thumbnail { get; set; }

                /// <summary>
                /// File identifiers of the stickers added to the photo, if applicable
                /// </summary>
                [JsonProperty("added_sticker_file_ids", ItemConverterType = typeof(Converter))]
                public int[] AddedStickerFileIds { get; set; }

                /// <summary>
                /// Photo width
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("width")]
                public int Width { get; set; }

                /// <summary>
                /// Photo height
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("height")]
                public int Height { get; set; }

                /// <summary>
                /// Photo caption; pass null to use an empty caption; 0-getOption("message_caption_length_max") characters
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText Caption { get; set; }

                /// <summary>
                /// Photo self-destruct type; pass null if none; private chats only
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("self_destruct_type")]
                public MessageSelfDestructType SelfDestructType { get; set; }

                /// <summary>
                /// True, if the photo preview must be covered by a spoiler animation; not supported in secret chats
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("has_spoiler")]
                public bool HasSpoiler { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
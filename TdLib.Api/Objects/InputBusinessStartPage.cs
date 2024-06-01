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
        /// <summary>
        /// Describes settings for a business account start page to set
        /// </summary>
        public partial class InputBusinessStartPage : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "inputBusinessStartPage";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Title text of the start page; 0-getOption("business_start_page_title_length_max") characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Message text of the start page; 0-getOption("business_start_page_message_length_max") characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message")]
            public string Message { get; set; }

            /// <summary>
            /// Greeting sticker of the start page; pass null if none. The sticker must belong to a sticker set and must not be a custom emoji
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public InputFile Sticker { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
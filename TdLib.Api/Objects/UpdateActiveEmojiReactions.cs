using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// The list of active emoji reactions has changed
            /// </summary>
            public class UpdateActiveEmojiReactions : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateActiveEmojiReactions";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The new list of active emoji reactions
                /// </summary>
                [JsonProperty("emojis", ItemConverterType = typeof(Converter))]
                public string[] Emojis { get; set; }
            }
        }
    }
}
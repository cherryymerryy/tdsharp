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
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The chat photo was changed
            /// </summary>
            public class ChatEventPhotoChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventPhotoChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous chat photo value; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_photo")]
                public ChatPhoto OldPhoto { get; set; }

                /// <summary>
                /// New chat photo value; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_photo")]
                public ChatPhoto NewPhoto { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
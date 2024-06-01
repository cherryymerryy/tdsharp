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
        public partial class Update : Object
        {
            /// <summary>
            /// The list of bots added to attachment or side menu has changed
            /// </summary>
            public class UpdateAttachmentMenuBots : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateAttachmentMenuBots";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The new list of bots. The bots must not be shown on scheduled messages screen
                /// </summary>
                [JsonProperty("bots", ItemConverterType = typeof(Converter))]
                public AttachmentMenuBot[] Bots { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
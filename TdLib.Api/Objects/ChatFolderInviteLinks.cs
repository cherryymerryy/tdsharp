using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Represents a list of chat folder invite links
        /// </summary>
        public partial class ChatFolderInviteLinks : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatFolderInviteLinks";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of the invite links
            /// </summary>
            [JsonProperty("invite_links", ItemConverterType = typeof(Converter))]
            public ChatFolderInviteLink[] InviteLinks { get; set; }
        }
    }
}
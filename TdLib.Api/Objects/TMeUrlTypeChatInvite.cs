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
        public partial class TMeUrlType : Object
        {
            /// <summary>
            /// A chat invite link
            /// </summary>
            public class TMeUrlTypeChatInvite : TMeUrlType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "tMeUrlTypeChatInvite";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Information about the chat invite link
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("info")]
                public ChatInviteLinkInfo Info { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
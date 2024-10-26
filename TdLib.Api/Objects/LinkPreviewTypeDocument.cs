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
        public partial class LinkPreviewType : Object
        {
            /// <summary>
            /// The link is a link to a general file
            /// </summary>
            public class LinkPreviewTypeDocument : LinkPreviewType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "linkPreviewTypeDocument";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The document description
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("document")]
                public Document Document { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
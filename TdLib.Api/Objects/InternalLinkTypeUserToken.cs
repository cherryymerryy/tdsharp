using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class InternalLinkType : Object
        {
            /// <summary>
            /// The link is a link to a user by a temporary token. Call searchUserByToken with the given token to process the link
            /// </summary>
            public class InternalLinkTypeUserToken : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypeUserToken";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The token
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("token")]
                public string Token { get; set; }
            }
        }
    }
}
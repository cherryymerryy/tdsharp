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
            /// The chat active usernames were changed
            /// </summary>
            public class ChatEventActiveUsernamesChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventActiveUsernamesChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous list of active usernames
                /// </summary>
                [JsonProperty("old_usernames", ItemConverterType = typeof(Converter))]
                public string[] OldUsernames { get; set; }

                /// <summary>
                /// New list of active usernames
                /// </summary>
                [JsonProperty("new_usernames", ItemConverterType = typeof(Converter))]
                public string[] NewUsernames { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
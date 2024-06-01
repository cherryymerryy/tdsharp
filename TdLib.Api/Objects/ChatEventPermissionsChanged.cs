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
            /// The chat permissions were changed
            /// </summary>
            public class ChatEventPermissionsChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventPermissionsChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Previous chat permissions
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_permissions")]
                public ChatPermissions OldPermissions { get; set; }

                /// <summary>
                /// New chat permissions
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_permissions")]
                public ChatPermissions NewPermissions { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
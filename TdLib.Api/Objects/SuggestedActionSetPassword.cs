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
        public partial class SuggestedAction : Object
        {
            /// <summary>
            /// Suggests the user to set a 2-step verification password to be able to log in again
            /// </summary>
            public class SuggestedActionSetPassword : SuggestedAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "suggestedActionSetPassword";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The number of days to pass between consecutive authorizations if the user declines to set password; if 0, then the user is advised to set the password for security reasons
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("authorization_delay")]
                public int AuthorizationDelay { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
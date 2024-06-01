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
        public partial class AuthorizationState : Object
        {
            /// <summary>
            /// TDLib needs the user's authentication code sent to an email address to authorize. Call checkAuthenticationEmailCode to provide the code
            /// </summary>
            public class AuthorizationStateWaitEmailCode : AuthorizationState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateWaitEmailCode";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// True, if authorization through Apple ID is allowed
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("allow_apple_id")]
                public bool AllowAppleId { get; set; }

                /// <summary>
                /// True, if authorization through Google ID is allowed
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("allow_google_id")]
                public bool AllowGoogleId { get; set; }

                /// <summary>
                /// Information about the sent authentication code
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("code_info")]
                public EmailAddressAuthenticationCodeInfo CodeInfo { get; set; }

                /// <summary>
                /// Reset state of the email address; may be null if the email address can't be reset
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("email_address_reset_state")]
                public EmailAddressResetState EmailAddressResetState { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
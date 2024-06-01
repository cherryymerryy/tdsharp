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
        /// <summary>
        /// Contains settings for the authentication of the user's phone number
        /// </summary>
        public partial class PhoneNumberAuthenticationSettings : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "phoneNumberAuthenticationSettings";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Pass true if the authentication code may be sent via a flash call to the specified phone number
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("allow_flash_call")]
            public bool AllowFlashCall { get; set; }

            /// <summary>
            /// Pass true if the authentication code may be sent via a missed call to the specified phone number
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("allow_missed_call")]
            public bool AllowMissedCall { get; set; }

            /// <summary>
            /// Pass true if the authenticated phone number is used on the current device
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_current_phone_number")]
            public bool IsCurrentPhoneNumber { get; set; }

            /// <summary>
            /// Pass true if there is a SIM card in the current device, but it is not possible to check whether phone number matches
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_unknown_phone_number")]
            public bool HasUnknownPhoneNumber { get; set; }

            /// <summary>
            /// For official applications only. True, if the application can use Android SMS Retriever API (requires Google Play Services &gt;= 10.2) to automatically receive the authentication code from the SMS. See https://developers.google.com/identity/sms-retriever/ for more details
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("allow_sms_retriever_api")]
            public bool AllowSmsRetrieverApi { get; set; }

            /// <summary>
            /// For official Android and iOS applications only; pass null otherwise. Settings for Firebase Authentication
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("firebase_authentication_settings")]
            public FirebaseAuthenticationSettings FirebaseAuthenticationSettings { get; set; }

            /// <summary>
            /// List of up to 20 authentication tokens, recently received in updateOption("authentication_token") in previously logged out sessions
            /// </summary>
            [JsonProperty("authentication_tokens", ItemConverterType = typeof(Converter))]
            public string[] AuthenticationTokens { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
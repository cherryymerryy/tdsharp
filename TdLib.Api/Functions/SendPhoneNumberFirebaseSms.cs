using System;
using System.Threading.Tasks;
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
        /// Sends Firebase Authentication SMS to the specified phone number. Works only when received a code of the type authenticationCodeTypeFirebaseAndroid or authenticationCodeTypeFirebaseIos
        /// </summary>
        public class SendPhoneNumberFirebaseSms : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendPhoneNumberFirebaseSms";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Play Integrity API or SafetyNet Attestation API token for the Android application, or secret from push notification for the iOS application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("token")]
            public string Token { get; set; }
        }

        /// <summary>
        /// Sends Firebase Authentication SMS to the specified phone number. Works only when received a code of the type authenticationCodeTypeFirebaseAndroid or authenticationCodeTypeFirebaseIos
        /// </summary>
        public static Task<Ok> SendPhoneNumberFirebaseSmsAsync(
            this Client client, string token = default)
        {
            return client.ExecuteAsync(new SendPhoneNumberFirebaseSms
            {
                Token = token
            });
        }
    }
}
// REUSE-IgnoreEnd
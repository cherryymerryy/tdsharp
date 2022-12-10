using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Resends the code to verify a phone number to be added to a user's Telegram Passport
        /// </summary>
        public class ResendPhoneNumberVerificationCode : Function<AuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resendPhoneNumberVerificationCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Resends the code to verify a phone number to be added to a user's Telegram Passport
        /// </summary>
        public static Task<AuthenticationCodeInfo> ResendPhoneNumberVerificationCodeAsync(
            this Client client)
        {
            return client.ExecuteAsync(new ResendPhoneNumberVerificationCode
            {
                
            });
        }
    }
}
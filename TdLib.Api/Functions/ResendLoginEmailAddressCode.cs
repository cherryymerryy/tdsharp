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
        /// Resends the login email address verification code
        /// </summary>
        public class ResendLoginEmailAddressCode : Function<EmailAddressAuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resendLoginEmailAddressCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Resends the login email address verification code
        /// </summary>
        public static Task<EmailAddressAuthenticationCodeInfo> ResendLoginEmailAddressCodeAsync(
            this Client client)
        {
            return client.ExecuteAsync(new ResendLoginEmailAddressCode
            {
                
            });
        }
    }
}
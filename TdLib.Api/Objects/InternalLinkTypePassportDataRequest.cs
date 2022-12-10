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
            /// The link contains a request of Telegram passport data. Call getPassportAuthorizationForm with the given parameters to process the link if the link was received from outside of the application, otherwise ignore it
            /// </summary>
            public class InternalLinkTypePassportDataRequest : InternalLinkType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "internalLinkTypePassportDataRequest";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// User identifier of the service's bot
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("bot_user_id")]
                public long BotUserId { get; set; }

                /// <summary>
                /// Telegram Passport element types requested by the service
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("scope")]
                public string Scope { get; set; }

                /// <summary>
                /// Service's public key
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("public_key")]
                public string PublicKey { get; set; }

                /// <summary>
                /// Unique request identifier provided by the service
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("nonce")]
                public string Nonce { get; set; }

                /// <summary>
                /// An HTTP URL to open once the request is finished or canceled with the parameter tg_passport=success or tg_passport=cancel respectively. If empty, then the link tgbot{bot_user_id}://passport/success or tgbot{bot_user_id}://passport/cancel needs to be opened instead
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("callback_url")]
                public string CallbackUrl { get; set; }
            }
        }
    }
}
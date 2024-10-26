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
        public partial class StarTransactionPartner : Object
        {
            /// <summary>
            /// The transaction is a transaction with a business account
            /// </summary>
            public class StarTransactionPartnerBusiness : StarTransactionPartner
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "starTransactionPartnerBusiness";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the business account user
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public long UserId { get; set; }

                /// <summary>
                /// The bought media if the transaction wasn't refunded
                /// </summary>
                [JsonProperty("media", ItemConverterType = typeof(Converter))]
                public PaidMedia[] Media { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
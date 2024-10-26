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
            /// The transaction is a transaction with Fragment
            /// </summary>
            public class StarTransactionPartnerFragment : StarTransactionPartner
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "starTransactionPartnerFragment";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// State of the withdrawal; may be null for refunds from Fragment
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("withdrawal_state")]
                public RevenueWithdrawalState WithdrawalState { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
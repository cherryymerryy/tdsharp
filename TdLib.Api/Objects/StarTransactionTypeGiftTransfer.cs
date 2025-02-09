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
        public partial class StarTransactionType : Object
        {
            /// <summary>
            /// The transaction is a transfer of an upgraded gift; for regular users only
            /// </summary>
            public class StarTransactionTypeGiftTransfer : StarTransactionType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "starTransactionTypeGiftTransfer";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the user or the channel that received the gift
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("owner_id")]
                public MessageSender OwnerId { get; set; }

                /// <summary>
                /// The gift
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("gift")]
                public UpgradedGift Gift { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
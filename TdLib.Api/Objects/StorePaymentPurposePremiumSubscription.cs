using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class StorePaymentPurpose : Object
        {
            /// <summary>
            /// Describes a purpose of an in-store payment
            /// </summary>
            public class StorePaymentPurposePremiumSubscription : StorePaymentPurpose
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "storePaymentPurposePremiumSubscription";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Pass true if this is a restore of a Telegram Premium purchase; only for App Store
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_restore")]
                public bool IsRestore { get; set; }
            }
        }
    }
}
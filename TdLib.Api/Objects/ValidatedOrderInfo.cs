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
        /// Contains a temporary identifier of validated order information, which is stored for one hour, and the available shipping options
        /// </summary>
        public partial class ValidatedOrderInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "validatedOrderInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Temporary identifier of the order information
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("order_info_id")]
            public string OrderInfoId { get; set; }

            /// <summary>
            /// Available shipping options
            /// </summary>
            [JsonProperty("shipping_options", ItemConverterType = typeof(Converter))]
            public ShippingOption[] ShippingOptions { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
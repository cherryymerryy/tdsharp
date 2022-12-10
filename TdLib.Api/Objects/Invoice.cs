using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Product invoice
        /// </summary>
        public partial class Invoice : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "invoice";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// ISO 4217 currency code
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("currency")]
            public string Currency { get; set; }

            /// <summary>
            /// A list of objects used to calculate the total price of the product
            /// </summary>
            [JsonProperty("price_parts", ItemConverterType = typeof(Converter))]
            public LabeledPricePart[] PriceParts { get; set; }

            /// <summary>
            /// The maximum allowed amount of tip in the smallest units of the currency
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("max_tip_amount")]
            public long MaxTipAmount { get; set; }

            /// <summary>
            /// Suggested amounts of tip in the smallest units of the currency
            /// </summary>
            [JsonProperty("suggested_tip_amounts", ItemConverterType = typeof(Converter))]
            public long[] SuggestedTipAmounts { get; set; }

            /// <summary>
            /// True, if the payment is a test payment
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_test")]
            public bool IsTest { get; set; }

            /// <summary>
            /// True, if the user's name is needed for payment
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("need_name")]
            public bool NeedName { get; set; }

            /// <summary>
            /// True, if the user's phone number is needed for payment
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("need_phone_number")]
            public bool NeedPhoneNumber { get; set; }

            /// <summary>
            /// True, if the user's email address is needed for payment
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("need_email_address")]
            public bool NeedEmailAddress { get; set; }

            /// <summary>
            /// True, if the user's shipping address is needed for payment
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("need_shipping_address")]
            public bool NeedShippingAddress { get; set; }

            /// <summary>
            /// True, if the user's phone number will be sent to the provider
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("send_phone_number_to_provider")]
            public bool SendPhoneNumberToProvider { get; set; }

            /// <summary>
            /// True, if the user's email address will be sent to the provider
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("send_email_address_to_provider")]
            public bool SendEmailAddressToProvider { get; set; }

            /// <summary>
            /// True, if the total price depends on the shipping method
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_flexible")]
            public bool IsFlexible { get; set; }
        }
    }
}
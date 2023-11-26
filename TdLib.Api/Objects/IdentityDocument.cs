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
        /// An identity document
        /// </summary>
        public partial class IdentityDocument : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "identityDocument";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Document number; 1-24 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("number")]
            public string Number { get; set; }

            /// <summary>
            /// Document expiration date; may be null if not applicable
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("expiration_date")]
            public Date ExpirationDate { get; set; }

            /// <summary>
            /// Front side of the document
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("front_side")]
            public DatedFile FrontSide { get; set; }

            /// <summary>
            /// Reverse side of the document; only for driver license and identity card; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reverse_side")]
            public DatedFile ReverseSide { get; set; }

            /// <summary>
            /// Selfie with the document; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("selfie")]
            public DatedFile Selfie { get; set; }

            /// <summary>
            /// List of files containing a certified English translation of the document
            /// </summary>
            [JsonProperty("translation", ItemConverterType = typeof(Converter))]
            public DatedFile[] Translation { get; set; }
        }
    }
}
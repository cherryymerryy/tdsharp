using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PremiumSource : Object
        {
            /// <summary>
            /// A user tried to use a Premium feature
            /// </summary>
            public class PremiumSourceFeature : PremiumSource
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "premiumSourceFeature";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The used feature
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("feature")]
                public PremiumFeature Feature { get; set; }
            }
        }
    }
}
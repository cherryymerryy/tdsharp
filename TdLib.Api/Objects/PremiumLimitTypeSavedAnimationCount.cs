using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PremiumLimitType : Object
        {
            /// <summary>
            /// The maximum number of saved animations
            /// </summary>
            public class PremiumLimitTypeSavedAnimationCount : PremiumLimitType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "premiumLimitTypeSavedAnimationCount";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
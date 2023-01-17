using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PushMessageContent : Object
        {
            /// <summary>
            /// A new recurrent payment was made by the current user
            /// </summary>
            public class PushMessageContentRecurringPayment : PushMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pushMessageContentRecurringPayment";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The paid amount
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("amount")]
                public string Amount { get; set; }
            }
        }
    }
}
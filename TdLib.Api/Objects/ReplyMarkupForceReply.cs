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
        public partial class ReplyMarkup : Object
        {
            /// <summary>
            /// Instructs application to force a reply to this message
            /// </summary>
            public class ReplyMarkupForceReply : ReplyMarkup
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "replyMarkupForceReply";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// True, if a forced reply must automatically be shown to the current user. For outgoing messages, specify true to show the forced reply only for the mentioned users and for the target user of a reply
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_personal")]
                public bool IsPersonal { get; set; }

                /// <summary>
                /// If non-empty, the placeholder to be shown in the input field when the reply is active; 0-64 characters
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("input_field_placeholder")]
                public string InputFieldPlaceholder { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
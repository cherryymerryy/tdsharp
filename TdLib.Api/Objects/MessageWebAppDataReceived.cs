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
        public partial class MessageContent : Object
        {
            /// <summary>
            /// Data from a Web App has been received; for bots only
            /// </summary>
            public class MessageWebAppDataReceived : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageWebAppDataReceived";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Text of the keyboardButtonTypeWebApp button, which opened the Web App
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("button_text")]
                public string ButtonText { get; set; }

                /// <summary>
                /// The data
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("data")]
                public string Data { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
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
        public partial class Update : Object
        {
            /// <summary>
            /// New call was created or information about a call was updated
            /// </summary>
            public class UpdateCall : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateCall";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// New data about a call
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("call")]
                public Call Call { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
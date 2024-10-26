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
        public partial class InputPaidMediaType : Object
        {
            /// <summary>
            /// Describes type of paid media to sent
            /// </summary>
            public class InputPaidMediaTypePhoto : InputPaidMediaType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPaidMediaTypePhoto";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
// REUSE-IgnoreEnd
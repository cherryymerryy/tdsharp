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
            /// The list of supported accent colors has changed
            /// </summary>
            public class UpdateAccentColors : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateAccentColors";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Information about supported colors; colors with identifiers 0 (red), 1 (orange), 2 (purple/violet), 3 (green), 4 (cyan), 5 (blue), 6 (pink) must always be supported
                /// </summary>
                [JsonProperty("colors", ItemConverterType = typeof(Converter))]
                public AccentColor[] Colors { get; set; }

                /// <summary>
                /// The list of accent color identifiers, which can be set through setAccentColor and setChatAccentColor. The colors must be shown in the specififed order
                /// </summary>
                [JsonProperty("available_accent_color_ids", ItemConverterType = typeof(Converter))]
                public int[] AvailableAccentColorIds { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
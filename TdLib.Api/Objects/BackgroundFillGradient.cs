using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class BackgroundFill : Object
        {
            /// <summary>
            /// Describes a gradient fill of a background
            /// </summary>
            public class BackgroundFillGradient : BackgroundFill
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "backgroundFillGradient";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// A top color of the background in the RGB24 format
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("top_color")]
                public int TopColor { get; set; }

                /// <summary>
                /// A bottom color of the background in the RGB24 format
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("bottom_color")]
                public int BottomColor { get; set; }

                /// <summary>
                /// Clockwise rotation angle of the gradient, in degrees; 0-359. Must always be divisible by 45
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("rotation_angle")]
                public int RotationAngle { get; set; }
            }
        }
    }
}
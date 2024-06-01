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
        public partial class StoryAreaType : Object
        {
            /// <summary>
            /// An area pointing to a suggested reaction. App needs to show a clickable reaction on the area and call setStoryReaction when the are is clicked
            /// </summary>
            public class StoryAreaTypeSuggestedReaction : StoryAreaType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "storyAreaTypeSuggestedReaction";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Type of the reaction
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("reaction_type")]
                public ReactionType ReactionType { get; set; }

                /// <summary>
                /// Number of times the reaction was added
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// True, if reaction has a dark background
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_dark")]
                public bool IsDark { get; set; }

                /// <summary>
                /// True, if reaction corner is flipped
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_flipped")]
                public bool IsFlipped { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
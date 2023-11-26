using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Contains basic information about a story
        /// </summary>
        public partial class StoryInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "storyInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique story identifier among stories of the given sender
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("story_id")]
            public int StoryId { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the story was published
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("date")]
            public int Date { get; set; }

            /// <summary>
            /// True, if the story is available only to close friends
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_for_close_friends")]
            public bool IsForCloseFriends { get; set; }
        }
    }
}
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Changes the order of pinned Saved Messages topics
        /// </summary>
        public class SetPinnedSavedMessagesTopics : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setPinnedSavedMessagesTopics";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifiers of the new pinned Saved Messages topics
            /// </summary>
            [JsonProperty("saved_messages_topic_ids", ItemConverterType = typeof(Converter))]
            public long[] SavedMessagesTopicIds { get; set; }
        }

        /// <summary>
        /// Changes the order of pinned Saved Messages topics
        /// </summary>
        public static Task<Ok> SetPinnedSavedMessagesTopicsAsync(
            this Client client, long[] savedMessagesTopicIds = default)
        {
            return client.ExecuteAsync(new SetPinnedSavedMessagesTopics
            {
                SavedMessagesTopicIds = savedMessagesTopicIds
            });
        }
    }
}
// REUSE-IgnoreEnd
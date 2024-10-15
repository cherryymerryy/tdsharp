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
        /// Adds a reaction or a tag to a message. Use getMessageAvailableReactions to receive the list of available reactions for the message
        /// </summary>
        public class AddMessageReaction : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addMessageReaction";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which the message belongs
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// Type of the reaction to add. Use addPendingPaidMessageReaction instead to add the paid reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reaction_type")]
            public ReactionType ReactionType { get; set; }

            /// <summary>
            /// Pass true if the reaction is added with a big animation
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_big")]
            public bool IsBig { get; set; }

            /// <summary>
            /// Pass true if the reaction needs to be added to recent reactions; tags are never added to the list of recent reactions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("update_recent_reactions")]
            public bool UpdateRecentReactions { get; set; }
        }

        /// <summary>
        /// Adds a reaction or a tag to a message. Use getMessageAvailableReactions to receive the list of available reactions for the message
        /// </summary>
        public static Task<Ok> AddMessageReactionAsync(
            this Client client, long chatId = default, long messageId = default, ReactionType reactionType = default, bool isBig = default, bool updateRecentReactions = default)
        {
            return client.ExecuteAsync(new AddMessageReaction
            {
                ChatId = chatId, MessageId = messageId, ReactionType = reactionType, IsBig = isBig, UpdateRecentReactions = updateRecentReactions
            });
        }
    }
}
// REUSE-IgnoreEnd
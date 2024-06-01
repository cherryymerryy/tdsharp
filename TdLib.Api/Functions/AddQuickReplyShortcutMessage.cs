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
        /// Adds a message to a quick reply shortcut. If shortcut doesn't exist and there are less than getOption("quick_reply_shortcut_count_max") shortcuts, then a new shortcut is created.
        /// The shortcut must not contain more than getOption("quick_reply_shortcut_message_count_max") messages after adding the new message. Returns the added message
        /// </summary>
        public class AddQuickReplyShortcutMessage : Function<QuickReplyMessage>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "addQuickReplyShortcutMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Name of the target shortcut
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("shortcut_name")]
            public string ShortcutName { get; set; }

            /// <summary>
            /// Identifier of a quick reply message in the same shortcut to be replied; pass 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_to_message_id")]
            public long ReplyToMessageId { get; set; }

            /// <summary>
            /// The content of the message to be added; inputMessagePoll, inputMessageForwarded and inputMessageLocation with live_period aren't supported
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("input_message_content")]
            public InputMessageContent InputMessageContent { get; set; }
        }

        /// <summary>
        /// Adds a message to a quick reply shortcut. If shortcut doesn't exist and there are less than getOption("quick_reply_shortcut_count_max") shortcuts, then a new shortcut is created.
        /// The shortcut must not contain more than getOption("quick_reply_shortcut_message_count_max") messages after adding the new message. Returns the added message
        /// </summary>
        public static Task<QuickReplyMessage> AddQuickReplyShortcutMessageAsync(
            this Client client, string shortcutName = default, long replyToMessageId = default, InputMessageContent inputMessageContent = default)
        {
            return client.ExecuteAsync(new AddQuickReplyShortcutMessage
            {
                ShortcutName = shortcutName, ReplyToMessageId = replyToMessageId, InputMessageContent = inputMessageContent
            });
        }
    }
}
// REUSE-IgnoreEnd
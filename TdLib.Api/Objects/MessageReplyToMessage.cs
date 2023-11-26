using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageReplyTo : Object
        {
            /// <summary>
            /// Contains information about the message or the story a message is replying to
            /// </summary>
            public class MessageReplyToMessage : MessageReplyTo
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageReplyToMessage";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The identifier of the chat to which the message belongs; may be 0 if the replied message is in unknown chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                /// <summary>
                /// The identifier of the message; may be 0 if the replied message is in unknown chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                /// <summary>
                /// Manually or automatically chosen quote from the replied message; may be null if none. Only Bold, Italic, Underline, Strikethrough, Spoiler, and CustomEmoji entities can be present in the quote
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("quote")]
                public FormattedText Quote { get; set; }

                /// <summary>
                /// True, if the quote was manually chosen by the message sender
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_quote_manual")]
                public bool IsQuoteManual { get; set; }

                /// <summary>
                /// Information about origin of the message if the message was from another chat or topic; may be null for messages from the same chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("origin")]
                public MessageOrigin Origin { get; set; }

                /// <summary>
                /// Point in time (Unix timestamp) when the message was sent if the message was from another chat or topic; 0 for messages from the same chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("origin_send_date")]
                public int OriginSendDate { get; set; }

                /// <summary>
                /// Media content of the message if the message was from another chat or topic; may be null for messages from the same chat and messages without media.
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("content")]
                public MessageContent Content { get; set; }
            }
        }
    }
}
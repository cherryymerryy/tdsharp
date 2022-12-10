using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Sends 2-10 messages grouped together into an album. Currently, only audio, document, photo and video messages can be grouped into an album. Documents and audio files can be only grouped in an album with messages of the same type. Returns sent messages
        /// </summary>
        public class SendMessageAlbum : Function<Messages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendMessageAlbum";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Target chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// If not 0, a message thread identifier in which the messages will be sent
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_thread_id")]
            public long MessageThreadId { get; set; }

            /// <summary>
            /// Identifier of a replied message; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_to_message_id")]
            public long ReplyToMessageId { get; set; }

            /// <summary>
            /// Options to be used to send the messages; pass null to use default options
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("options")]
            public MessageSendOptions Options { get; set; }

            /// <summary>
            /// Contents of messages to be sent. At most 10 messages can be added to an album
            /// </summary>
            [JsonProperty("input_message_contents", ItemConverterType = typeof(Converter))]
            public InputMessageContent[] InputMessageContents { get; set; }

            /// <summary>
            /// Pass true to get fake messages instead of actually sending them
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("only_preview")]
            public bool OnlyPreview { get; set; }
        }

        /// <summary>
        /// Sends 2-10 messages grouped together into an album. Currently, only audio, document, photo and video messages can be grouped into an album. Documents and audio files can be only grouped in an album with messages of the same type. Returns sent messages
        /// </summary>
        public static Task<Messages> SendMessageAlbumAsync(
            this Client client, long chatId = default, long messageThreadId = default, long replyToMessageId = default, MessageSendOptions options = default, InputMessageContent[] inputMessageContents = default, bool onlyPreview = default)
        {
            return client.ExecuteAsync(new SendMessageAlbum
            {
                ChatId = chatId, MessageThreadId = messageThreadId, ReplyToMessageId = replyToMessageId, Options = options, InputMessageContents = inputMessageContents, OnlyPreview = onlyPreview
            });
        }
    }
}
using System;
using Newtonsoft.Json;

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
            /// A new incoming callback query; for bots only
            /// </summary>
            public class UpdateNewCallbackQuery : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateNewCallbackQuery";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique query identifier
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("id")]
                public long Id { get; set; }

                /// <summary>
                /// Identifier of the user who sent the query
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("sender_user_id")]
                public long SenderUserId { get; set; }

                /// <summary>
                /// Identifier of the chat where the query was sent
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                /// <summary>
                /// Identifier of the message from which the query originated
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                /// <summary>
                /// Identifier that uniquely corresponds to the chat to which the message was sent
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("chat_instance")]
                public long ChatInstance { get; set; }

                /// <summary>
                /// Query payload
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("payload")]
                public CallbackQueryPayload Payload { get; set; }
            }
        }
    }
}
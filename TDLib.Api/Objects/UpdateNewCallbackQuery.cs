using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class Update : Object
        {
            public class UpdateNewCallbackQuery : Update
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "updateNewCallbackQuery";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("id")]
                public Int64 Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sender_user_id")]
                public int SenderUserId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("chat_instance")]
                public Int64 ChatInstance { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("payload")]
                public CallbackQueryPayload Payload { get; set; }
            }
        }
    }
}
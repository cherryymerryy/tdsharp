using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageSponsorType : Object
        {
            /// <summary>
            /// The sponsor is a private channel chat
            /// </summary>
            public class MessageSponsorTypePrivateChannel : MessageSponsorType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageSponsorTypePrivateChannel";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Title of the chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// Invite link for the channel
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("invite_link")]
                public string InviteLink { get; set; }
            }
        }
    }
}
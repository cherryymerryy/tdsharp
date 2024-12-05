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
        /// <summary>
        /// Describes a found affiliate program
        /// </summary>
        public partial class FoundAffiliateProgram : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "foundAffiliateProgram";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// User identifier of the bot created the program
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_user_id")]
            public long BotUserId { get; set; }

            /// <summary>
            /// Information about the affiliate program
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("parameters")]
            public AffiliateProgramInfo Parameters { get; set; }
        }
    }
}
// REUSE-IgnoreEnd
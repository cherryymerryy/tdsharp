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
        public partial class Update : Object
        {
            /// <summary>
            /// Information about a group call participant was changed. The updates are sent only after the group call is received through getGroupCall and only if the call is joined or being joined
            /// </summary>
            public class UpdateGroupCallParticipant : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateGroupCallParticipant";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of group call
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("group_call_id")]
                public int GroupCallId { get; set; }

                /// <summary>
                /// New data about a participant
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("participant")]
                public GroupCallParticipant Participant { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd
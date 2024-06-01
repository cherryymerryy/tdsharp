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
        /// Toggles whether non-administrators can receive only administrators and bots using getSupergroupMembers or searchChatMembers. Can be called only if supergroupFullInfo.can_hide_members == true
        /// </summary>
        public class ToggleSupergroupHasHiddenMembers : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleSupergroupHasHiddenMembers";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the supergroup
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public long SupergroupId { get; set; }

            /// <summary>
            /// New value of has_hidden_members
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_hidden_members")]
            public bool HasHiddenMembers { get; set; }
        }

        /// <summary>
        /// Toggles whether non-administrators can receive only administrators and bots using getSupergroupMembers or searchChatMembers. Can be called only if supergroupFullInfo.can_hide_members == true
        /// </summary>
        public static Task<Ok> ToggleSupergroupHasHiddenMembersAsync(
            this Client client, long supergroupId = default, bool hasHiddenMembers = default)
        {
            return client.ExecuteAsync(new ToggleSupergroupHasHiddenMembers
            {
                SupergroupId = supergroupId, HasHiddenMembers = hasHiddenMembers
            });
        }
    }
}
// REUSE-IgnoreEnd
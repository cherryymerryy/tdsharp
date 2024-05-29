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
        /// Loads quick reply shortcuts created by the current user. The loaded topics will be sent through updateQuickReplyShortcuts
        /// </summary>
        public class LoadQuickReplyShortcuts : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "loadQuickReplyShortcuts";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }


        }

        /// <summary>
        /// Loads quick reply shortcuts created by the current user. The loaded topics will be sent through updateQuickReplyShortcuts
        /// </summary>
        public static Task<Ok> LoadQuickReplyShortcutsAsync(
            this Client client)
        {
            return client.ExecuteAsync(new LoadQuickReplyShortcuts
            {
                
            });
        }
    }
}